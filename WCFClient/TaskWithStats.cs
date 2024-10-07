using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFClient.WcfServiceReference;

namespace WCFClient
{
    public class TaskWithStats
    {
        // params
        private string sURL = "";
        private int MsgSize = 0;
        private int MaxMessages = 0;

        // exposed
        public StatsCounter stats = new StatsCounter();
        
        public Thread thread = null;
        public Task task = null;

        // flag to run / stop
        private bool bKeepRunning = false;

        public void StartThreadOrTask(string sURL, int MsgSize, int MaxMessages, bool bUseThread)
        {
            this.sURL = sURL;
            this.MsgSize = MsgSize;
            this.MaxMessages = MaxMessages;

            bKeepRunning = true;

            if (bUseThread)
            {
                thread = new Thread(new ThreadStart(StressTestFunc));
                thread.Start();
            }
            else
            {
                task = new Task(StressTestFunc);
                task.Start();
            }
        }

        public void SignalToStop()
        {
            bKeepRunning = false;
        }

        private void StressTestFunc()
        {
            String sBase = "";

            DataServiceClient client = null;

            // prep
            try
            {
                Random rnd = new Random((int)DateTime.Now.Ticks);

                StringBuilder sb = new StringBuilder(MsgSize);
                for (int i = 0; i < MsgSize; i++)
                {
                    // random string with lower ASCII chars
                    char ch = (char)(' ' + rnd.Next('~' - ' '));
                    sb.Append(ch);
                }
                sBase = sb.ToString();

                var binding = WCFServer.WCF.MyHttpBinding.MyBinding();
                var address = new System.ServiceModel.EndpointAddress(sURL);
                client = new WcfServiceReference.DataServiceClient(binding, address);

                // do a Ping to test connection
                string s = client.Ping("Test");
                if (String.IsNullOrEmpty(s))
                {
                    throw new Exception("Cannot do Ping");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot start: " + ex.Message);
                return;
            }

            // reset stats
            stats.StartBatch();

            // loop
            int iMessage = 0;
            while (bKeepRunning)
            {
                if (MaxMessages > 0 &&
                    iMessage >= MaxMessages)
                {
                    break;
                }

                DateTime dt_start = PreciseDateTime.Now;

                try
                {
                    iMessage++;

                    string sRequestWithNumber = sBase + iMessage.ToString();
                    WCFClient.WcfServiceReference.DataResponse resp = client.Ping2(sRequestWithNumber);

                    DateTime dt_end = PreciseDateTime.Now;

                    if (String.IsNullOrEmpty(resp.Response))
                    {
                        throw new Exception("Empty Message");
                    }
                    else
                    {
                        stats.AddSuccess(dt_start, dt_end);
                    }
                }
                catch
                {
                    DateTime dt_end = PreciseDateTime.Now;

                    stats.AddError(dt_start, dt_end);
                }
            }

            stats.StopBatch();
        }

    }
}
