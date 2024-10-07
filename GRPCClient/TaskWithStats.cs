using Grpc.Net.Client;
using GRPCServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRPCClient
{
    public class TaskWithStats
    {
        // params
        private string sURL = "";
        private int MsgSize = 0;
        private int MaxMessages = 0;

        // exposed
        public StatsCounter stats = new StatsCounter();

        public Thread? thread = null;
        public Task? task = null;

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

            GrpcTest.GrpcTestClient client;

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

                var channel = GrpcChannel.ForAddress(sURL);
                client = new GrpcTest.GrpcTestClient(channel);

                // do a Ping to test connection
                PingRequest input = new PingRequest { Data = "Test" };
                PingResponse reply = client.Ping(input);
                if (String.IsNullOrEmpty(reply.Data))
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

                    Ping2Request input = new Ping2Request();
                    input.Data = sRequestWithNumber;

                    Ping2Response reply = client.Ping2(input);

                    DateTime dt_end = PreciseDateTime.Now;

                    if (String.IsNullOrEmpty(reply.Data))
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
