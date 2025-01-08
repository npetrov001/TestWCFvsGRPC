using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Runtime.Remoting.Messaging;

namespace WCFServer.WCF
{
    public class MyBindings
    {
        public static System.ServiceModel.Channels.Binding Http_or_Tcp(bool bHttp)
        {
            if (bHttp)
            {
                return _HttpBinding1();
            }
            else
            {
                return _TcpBinding2();
            }
        }

        private static System.ServiceModel.BasicHttpBinding _HttpBinding1()
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

        private static System.ServiceModel.Channels.CustomBinding _TcpBinding2()
        {
            System.ServiceModel.Channels.CustomBinding binding = new System.ServiceModel.Channels.CustomBinding
            {
                OpenTimeout = new TimeSpan(0, 0, 10),
                SendTimeout = new TimeSpan(0, 0, 20),
                ReceiveTimeout = new TimeSpan(0, 0, 20),
                CloseTimeout = new TimeSpan(0, 0, 10),
            };
            binding.Elements.Add(new BinaryMessageEncodingBindingElement());
            binding.Elements.Add(new TcpTransportBindingElement { MaxReceivedMessageSize = 1200300 }); // 1M

            return binding;
        }
    }
}
