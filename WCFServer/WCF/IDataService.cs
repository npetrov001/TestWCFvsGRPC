using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFServer.WCF
{
    [ServiceContract]
    public interface IDataService
    {
        [OperationContract]
        string Ping(string sMessage);

        [OperationContract]
        DataResponse Ping2(string sMessage);

    }
}
