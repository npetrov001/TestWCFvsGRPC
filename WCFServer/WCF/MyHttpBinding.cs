using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFServer.WCF
{
    public class MyHttpBinding
    {
        public static System.ServiceModel.BasicHttpBinding MyBinding()
        {
            System.ServiceModel.BasicHttpBinding binding = new System.ServiceModel.BasicHttpBinding
            {
                OpenTimeout = new TimeSpan(0, 0, 10),
                SendTimeout = new TimeSpan(0, 0, 20),
                ReceiveTimeout = new TimeSpan(0, 0, 20),
                CloseTimeout = new TimeSpan(0, 0, 10),
                MaxReceivedMessageSize = 1200300, // 1M
                ReaderQuotas = new System.Xml.XmlDictionaryReaderQuotas
                {
                    MaxStringContentLength = 1200300, // 1M
                    MaxArrayLength = 1200300 // 1M
                }
            };
            binding.Security.Mode = BasicHttpSecurityMode.None;
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            return binding;
        }

    }
}
