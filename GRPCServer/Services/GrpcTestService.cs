using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRPCServer.Services
{
    public class GrpcTestService : GrpcTest.GrpcTestBase
    {
        public delegate void OnRequestCountFunc();
        public static event OnRequestCountFunc? OnRequestCountEvent = null;

        private readonly ILogger<GrpcTestService> _logger;
        public GrpcTestService(ILogger<GrpcTestService> logger)
        {
            _logger = logger;
        }

        public override Task<PingResponse> Ping(PingRequest request, ServerCallContext context)
        {
            PingResponse resp = new PingResponse();
            resp.Data = request.Data;
            return Task.FromResult(resp);
        }

        public override Task<Ping2Response> Ping2(Ping2Request request, ServerCallContext context)
        {
            if (OnRequestCountEvent != null)
            {
                OnRequestCountEvent();
            }

            Ping2Response resp = new Ping2Response();
            resp.Success = true;
            resp.Message = "OK";
            resp.Data = request.Data;
            return Task.FromResult(resp);
        }
    }
}
