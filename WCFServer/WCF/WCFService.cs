using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WCFServer.WCF
{
    public class WCFService : IDataService
    {
        public delegate void OnRequestCountFunc();
        public static event OnRequestCountFunc OnRequestCountEvent = null;

        public string Ping(string sMessage)
        {
            return sMessage;
        }

        public DataResponse Ping2(string sMessage)
        {
            if (OnRequestCountEvent != null)
            {
                OnRequestCountEvent();
            }

            DataResponse resp = new DataResponse();
            resp.Success = true;
            resp.Message = "OK";
            resp.Response = sMessage;
            return resp;
        }
    }
}
