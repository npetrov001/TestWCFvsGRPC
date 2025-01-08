using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading;
using System.ServiceModel.Configuration;

namespace WCFClient
{
    public partial class Form1 : Form
    {
        // running tasks
        List<TaskWithStats> lstTasks = null;

        // GridView Display
        private class RecGridView
        {
            public string ThreadNum { get; set; }
            public string Success { get; set; }
            public string Errors { get; set; }
            public string ReqPerSec { get; set; }
            public string AvgMs { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblArchitecture.Text = "Architecture: " + System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture.ToString() +
                " - .NET v" + Environment.Version;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            DateTime dtStart = PreciseDateTime.Now;

            try
            {
                System.ServiceModel.Channels.Binding binding = 
                    WCFServer.WCF.MyBindings.Http_or_Tcp(rdoHttpBinding.Checked);

                EndpointAddress address = new System.ServiceModel.EndpointAddress(txtURL.Text.Trim());

                using(WcfServiceReference.DataServiceClient client = new WcfServiceReference.DataServiceClient(binding, address))
                {
                    string sResponse = client.Ping("Test");

                    TimeSpan ts = PreciseDateTime.Now - dtStart;

                    txtOut.Text = String.Format("Time: {0} ms\r\nResponse: {1}", ts.TotalMilliseconds.ToString("#,0.00"), sResponse);

                    // enable stress test
                    btnStressStart.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                TimeSpan ts = PreciseDateTime.Now - dtStart;

                txtOut.Text = String.Format("Time: {0} ms\r\nError: {1}\r\n", ts.TotalMilliseconds.ToString("#,0.00"), ex.Message);

                // disable stress test
                btnStressStart.Enabled = false;
            }
        }

        private int ParseNumberThrowOnError(TextBox txt, string sParamName, int min, int max)
        {
            int n = 0;
            bool bSuccess = false;
            try
            {
                n = int.Parse(txt.Text, System.Globalization.NumberStyles.Currency);
                if (n >= min && n <= max)
                {
                    bSuccess = true;
                }
            }
            catch { }
            if (bSuccess)
            {
                return n;
            }
            else
            {
                txt.Focus();
                throw new Exception(sParamName + " must be between " + min.ToString("#,0") + " and " + max.ToString("#,0"));
            }
        }

        void EnableDisableParams(bool b)
        {
            txtURL.Enabled = b;
            txtMessageSize.Enabled = b;
            txtMaxMessages.Enabled = b;
            txtThreads.Enabled = b; 
            rdoThreads.Enabled = b;
            rdoTasks.Enabled = b;
        }

        private async void btnStressStart_Click(object sender, EventArgs e)
        {
            btnStressStart.Enabled = false;
            btnStressStop.Enabled = true;

            try
            {
                txtStressTest.Text = "Starting...";

                // disable inputs
                EnableDisableParams(false);
                
                // params
                string sURL = txtURL.Text.Trim();
                int nMsgSize = ParseNumberThrowOnError(txtMessageSize, "Message Size", 1, 10 * 1000 * 1000);
                int nMaxMessages = ParseNumberThrowOnError(txtMaxMessages, "Max # of Messages", 0, 10 * 1000 * 1000);
                int nThreads = ParseNumberThrowOnError(txtThreads, "# of Threads", 1, 1000);

                bool bUseThreads = rdoThreads.Checked;

                // start tasks
                lstTasks = new List<TaskWithStats>();

                for (int i = 0; i < nThreads; i++)
                {
                    TaskWithStats tt = new TaskWithStats(sURL, rdoHttpBinding.Checked, nMsgSize, nMaxMessages);
                    tt.StartThreadOrTask(bUseThreads);
                    lstTasks.Add(tt);
                }

                timerRefresh.Enabled = true;

                if (bUseThreads)
                {
                    // wait list for threads
                    List<Thread> lstWaitThreads = lstTasks.Select(x => x.thread).ToList();

                    // wait for all threads to finish
                    while (true)
                    {
                        bool bBreak = true;
                        foreach (Thread thread in lstWaitThreads)
                        {
                            if (thread.IsAlive)
                            {
                                bBreak = false;
                            }
                        }
                        if (bBreak)
                        {
                            break;
                        }

                        Application.DoEvents();
                        Thread.Sleep(10);
                    }
                }
                else
                {
                    // wait list for tasks
                    List<Task> lstWaitTasks = lstTasks.Select(x => x.task).ToList();

                    // wait for all tasks to finish
                    await Task.WhenAll(lstWaitTasks.ToArray());
                }

                // try catch to ignore errors if program closed
                try
                {
                    // stop timer refresh
                    timerRefresh.Enabled = false;

                    // last update
                    timerRefresh_Tick(null, null);

                    // re-enable inputs
                    EnableDisableParams(true);
                }
                catch { }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            btnStressStart.Enabled = true;
            btnStressStop.Enabled = false;
        }

        private void btnStressStop_Click(object sender, EventArgs e)
        {
            if (lstTasks != null)
            {
                foreach (TaskWithStats tt in lstTasks)
                {
                    tt.SignalToStop();
                }
                lstTasks = null;
            }
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            // lstTasks = null if window is closed
            if (lstTasks == null) return;

            // 1) get stats data from tasks
            List<StatsData> lstStats = new List<StatsData>();
            foreach (TaskWithStats tt in lstTasks)
            {
                StatsData data = tt.stats.GetData();
                lstStats.Add(data);
            }

            // 2) show in grid
            List<RecGridView> lstGridView = new List<RecGridView>();
            foreach (StatsData data in lstStats)
            {
                RecGridView rec = new RecGridView();
                rec.ThreadNum = (lstGridView.Count + 1).ToString();
                rec.Success = data.TotalSuccess.ToString("#,0");
                rec.Errors = data.TotalErrors.ToString("#,0");
                rec.ReqPerSec = data.GetReqPerSec().ToString("#,0");
                rec.AvgMs = data.GetAvgMs().ToString("#,0.00");
                lstGridView.Add(rec);
            }
            gridStats.AutoGenerateColumns = false;
            gridStats.DataSource = null;
            gridStats.DataSource = lstGridView;

            // 2) calc total stats
            StatsData total = new StatsData();
            total.dtBatchStarted = lstStats[0].dtBatchStarted;
            total.dtBatchStopped = lstStats[0].dtBatchStopped;
            total.success_latency_min_ms = lstStats[0].success_latency_min_ms;
            foreach (StatsData data in lstStats)
            {
                // totals
                total.TotalSuccess += data.TotalSuccess;
                total.TotalErrors += data.TotalErrors;
                total.success_latency_avg_ms_numerator += data.success_latency_avg_ms_numerator;
                total.error_latency_avg_ms_numerator += data.error_latency_avg_ms_numerator;
                // min
                if (total.success_latency_min_ms > data.success_latency_min_ms)
                {
                    total.success_latency_min_ms = data.success_latency_min_ms;
                }
                // max
                if (total.success_latency_max_ms < data.success_latency_max_ms)
                {
                    total.success_latency_max_ms = data.success_latency_max_ms;
                }
            }

            // 3) show total stats
            txtStressTest.Text =
                "Req/sec: " + total.GetReqPerSec().ToString("#,0") + "\r\n" +
                "Success: " + total.TotalSuccess.ToString("#,0") + "\r\n" +
                "Errors:  " + total.TotalErrors.ToString("#,0") + "\r\n" +
                "Min ms:  " + total.success_latency_min_ms.ToString("#,0.00") + "\r\n" +
                "Max ms:  " + total.success_latency_max_ms.ToString("#,0.00") + "\r\n" +
                "Avg ms:  " + total.GetAvgMs().ToString("#,0.00") + "\r\n" +
                "Avg Error ms:  " + total.GetAvgErrorMs().ToString("#,0.00");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // window is being closed

            // 1) stop refreshing data
            timerRefresh.Enabled = false;
            
            // stop processing
            btnStressStop_Click(null, null);

            // wait a bit
            Thread.Sleep(100);
        }

        private void rdoHttpBinding_CheckedChanged(object sender, EventArgs e)
        {
            ReplaceUrlProtocol("http");
        }

        private void rdoTcpBinding_CheckedChanged(object sender, EventArgs e)
        {
            ReplaceUrlProtocol("net.tcp");
        }

        private void ReplaceUrlProtocol(string sPrefix)
        {
            string sURL = txtURL.Text.Trim();
            int i1 = sURL.IndexOf("//");
            if (i1 >= 0)
            {
                sURL = sPrefix + ":" + sURL.Substring(i1);
            }
            else
            {
                sURL = sPrefix + "://" + sURL;
            }
            txtURL.Text = sURL;
        }

    }
}
