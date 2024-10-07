using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFClient
{
    public class StatsData
    {
        public DateTime dtBatchStarted = DateTime.MinValue;
        public DateTime dtBatchStopped = DateTime.MinValue;

        public int TotalSuccess = 0;
        public int TotalErrors = 0;
        
        public double success_latency_avg_ms_numerator = 0;
        public double success_latency_min_ms = 0;
        public double success_latency_max_ms = 0;
        public double error_latency_avg_ms_numerator = 0;

        public void Clear()
        {
            dtBatchStarted = DateTime.MinValue;
            dtBatchStopped = DateTime.MinValue;

            TotalSuccess = 0;
            TotalErrors = 0;
            
            success_latency_avg_ms_numerator = 0;
            success_latency_min_ms = 0;
            success_latency_max_ms = 0;
            error_latency_avg_ms_numerator = 0;
        }

        public int GetReqPerSec()
        {
            DateTime dtStopped = dtBatchStopped;
            
            // if not stopped yet - use current time
            if (dtStopped == DateTime.MinValue)
            {
                dtStopped = PreciseDateTime.Now;
            }
            
            TimeSpan ts_total = dtStopped - dtBatchStarted;

            return (int)((TotalSuccess + TotalErrors) / ts_total.TotalSeconds);
        }

        public double GetAvgMs()
        {
            if (TotalSuccess == 0)
            {
                return 0;
            }
            else
            {
                return success_latency_avg_ms_numerator / TotalSuccess;
            }
        }

        public double GetAvgErrorMs()
        {
            if (TotalErrors == 0)
            {
                return 0;
            }
            else
            {
                return error_latency_avg_ms_numerator / TotalErrors;
            }
        }

        public StatsData MakeCopy()
        {
            StatsData data2 = new StatsData();

            data2.dtBatchStarted = this.dtBatchStarted;
            data2.dtBatchStopped = this.dtBatchStopped;

            data2.TotalSuccess = this.TotalSuccess;
            data2.TotalErrors = this.TotalErrors;

            data2.success_latency_avg_ms_numerator = this.success_latency_avg_ms_numerator;
            data2.success_latency_min_ms = this.success_latency_min_ms;
            data2.success_latency_max_ms = this.success_latency_max_ms;
            data2.error_latency_avg_ms_numerator = this.error_latency_avg_ms_numerator;

            return data2;
        }
    }
}
