using GRPCServer.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GRPCServer
{
    public partial class Form1 : Form
    {
        WebApplicationBuilder? builder = null;
        WebApplication? app = null;

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
            Services.GrpcTestService.OnRequestCountEvent += GrpcTestService_OnRequestCountEvent;
        }

        private void GrpcTestService_OnRequestCountEvent()
        {
            stats.AddRequest();
        }

        private async void btnStartServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (builder == null)
                {
                    btnStartServer.Enabled = false;
                    btnStopServer.Enabled = true;

                    stats.Clear();
                    timerRefresh.Enabled = true;

                    builder = WebApplication.CreateBuilder();
                    
                    // configure as HTTP/2 only endpoint to avoid errors when using HTTP instead of HTTPS
                    builder.WebHost.ConfigureKestrel(options => 
                        options.ConfigureEndpointDefaults(defaults => 
                            defaults.Protocols = Microsoft.AspNetCore.Server.Kestrel.Core.HttpProtocols.Http2));
                    
                    builder.Services.AddGrpc();
                    app = builder.Build();

                    app.Urls.Add(txtURL.Text.Trim());
                    app.MapGrpcService<Services.GrpcTestService>();
                    app.MapGet("/", () => "Test GRPC Server.");

                    await app.RunAsync();
                }
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

                if (app != null)
                {
                    app.StopAsync();
                    app.DisposeAsync();
                    app = null;
                }
                builder = null;
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
