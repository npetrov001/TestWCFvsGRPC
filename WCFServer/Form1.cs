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
using System.Security.Policy;
using WCFServer.WCF;
using System.ServiceModel.Description;

namespace WCFServer
{
    public partial class Form1 : Form
    {
        ServiceHost wcf_server = null;

        RequestStats stats = new RequestStats();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblArchitecture.Text = "Architecture: " + System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture.ToString() +
                " - .NET v" + Environment.Version;

            // count requests
            WCF.WCFService.OnRequestCountEvent += WCFService_OnRequestCountEvent;
            
        }

        private void WCFService_OnRequestCountEvent()
        {
            stats.AddRequest();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            try
            {
                btnStartServer.Enabled = false;
                btnStopServer.Enabled = true;

                stats.Clear();
                timerRefresh.Enabled = true;

                string sUrl = txtURL.Text.Trim();
                Uri[] baseAddr = new Uri[] { new Uri(sUrl) };
                wcf_server = new ServiceHost(typeof(WCF.WCFService), baseAddr);

                // wcf_server.Faulted += new EventHandler();
                // wcf_server.Closing += new EventHandler();
                // wcf_server.Closed += new EventHandler();
                // wcf_server.UnknownMessageReceived += new EventHandler<UnknownMessageReceivedEventArgs>();

                // MEX for auto publishing
#if DEBUG
                ServiceMetadataBehavior mex = wcf_server.Description.Behaviors.Find<ServiceMetadataBehavior>();
                if (mex == null)
                {
                    mex = new ServiceMetadataBehavior();
                    wcf_server.Description.Behaviors.Add(mex);
                }
                mex.HttpGetEnabled = true;
                System.ServiceModel.Channels.Binding binding_mex = MetadataExchangeBindings.CreateMexHttpBinding();
                wcf_server.AddServiceEndpoint(typeof(IDataService), binding_mex, "mex");
#endif

                BasicHttpBinding binding = WCF.MyHttpBinding.MyBinding();
                wcf_server.AddServiceEndpoint(typeof(WCF.IDataService), binding, "");

                wcf_server.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            try
            {
                btnStartServer.Enabled = true;
                btnStopServer.Enabled = false;

                timerRefresh.Enabled = false;

                if (wcf_server != null)
                {
                    wcf_server.Close();
                    wcf_server = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            int reqs1 = 0;
            int reqs10 = 0;
            
            stats.NextSecond(out reqs1, out reqs10);

            lblReqPerSec.Text = reqs1.ToString("#,0");
            lblReqPerSec10.Text = reqs10.ToString("#,0");

            lblTime.Text = DateTime.Now.ToString("HH:mm:ss.fff");
        }
    }
}
