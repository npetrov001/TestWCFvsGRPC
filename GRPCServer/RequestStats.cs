using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRPCServer
{
    internal class RequestStats
    {
        // store in array instead of a list to avoid unnecessary allocation / deallocation
        private const int MaxSec = 10;
        private int[] arrRequestPerSec = new int[MaxSec];

        public void Clear()
        {
            for (int i = 0; i < MaxSec; i++)
            {
                arrRequestPerSec[i] = 0;
            }
        }


        public void AddRequest()
        {
            lock (this)
            {
                // 0 element stores most recent
                arrRequestPerSec[0]++;
            }
        }

        // return stats each time we advance to next sec
        public void NextSecond(out int ret_reqs1, out int ret_reqs10)
        {
            lock (this)
            {
                ret_reqs1 = arrRequestPerSec[0];
                ret_reqs10 = ret_reqs1;

                // shift right and calc reqs10
                for (int i = MaxSec - 1; i > 0; i--)
                {
                    ret_reqs10 += arrRequestPerSec[i];
                    arrRequestPerSec[i] = arrRequestPerSec[i - 1];
                }
                // reset [0] element
                arrRequestPerSec[0] = 0;

                ret_reqs10 = ret_reqs10 / MaxSec;
            }
        }

    }
}
