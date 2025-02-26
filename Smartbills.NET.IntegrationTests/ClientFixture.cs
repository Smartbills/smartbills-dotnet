using Smartbills.NET.Infrastructure;
using System;
using System.Collections.Generic;

namespace Smartbills.NET.IntegrationTests
{
    public class ClientFixture : IDisposable
    {

        public SmartbillsClient _client;
        public ClientFixture()
        {
            _client = new SmartbillsClient(new SmartbillsClientOption
            {
                Endpoints = new SBEndpoints()
                {
                    AuthUrl = "http://localhost:8000",
                    Url= "https://localhost:44301",
                },
                SessionId =  Guid.NewGuid().ToString()
            });
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }


}
