# TestWCFvsGRPC

This repo contains 2 sets of 2 projects:
1) GRPC Client + Server - C# WinForms .NET 8
2) WCF Client + Server - C# WinForms .NET Framework 4.8

Both servers and clients are structured similarly with similar UI.

Both servers expose 2 simple methods:
1) Ping() - accepts input string and responds with the same string
2) Ping2() - accepts input string and responds with a common structure of Success flag, Message and data (which gets the same string returned).

The purpose of these projects was to benchmark if GRPC is actually faster than WCF, more light-weight and can handle more concurrent requests.

Results did in fact confirm these claims.


