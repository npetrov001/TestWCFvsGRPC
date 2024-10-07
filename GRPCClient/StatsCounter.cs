using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRPCClient
{
    /// <summary>
    /// data in this class is safe for Concurrency
    /// </summary>
    public class StatsCounter
    {
        private StatsData data = new StatsData();

        public void StartBatch()
        {
            lock (this)
            {
                data.Clear();
                data.dtBatchStarted = PreciseDateTime.Now;
            }
        }

        public void StopBatch()
        {
            lock (this)
            {
                data.dtBatchStopped = PreciseDateTime.Now;
            }
        }

        // pass PreciseDateTime
        public void AddSuccess(DateTime dtStarted, DateTime dtEnded)
        {
            lock (this)
            {
                TimeSpan ts = dtEnded - dtStarted;
                double millis = ts.TotalMilliseconds;
                if (data.TotalSuccess == 0)
                {
                    data.success_latency_min_ms = millis;
                    data.success_latency_max_ms = millis;
                    data.success_latency_avg_ms_numerator = millis;
                }
                else
                {
                    if (millis < data.success_latency_min_ms)
                    {
                        data.success_latency_min_ms = millis;
                    }
                    if (millis > data.success_latency_max_ms)
                    {
                        data.success_latency_max_ms = millis;
                    }
                    data.success_latency_avg_ms_numerator += millis;
                }
                data.TotalSuccess++;
            }
        }

        // pass PreciseDateTime
        public void AddError(DateTime dtStarted, DateTime dtEnded)
        {
            lock (this)
            {
                TimeSpan ts = dtEnded - dtStarted;
                data.error_latency_avg_ms_numerator += ts.TotalMilliseconds;
                data.TotalErrors++;
            }
        }

        public StatsData GetData()
        {
            lock (this)
            {
                StatsData data2 = data.MakeCopy();
                return data2;
            }
        }
    }
}
