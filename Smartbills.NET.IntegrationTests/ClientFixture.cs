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
            _client = new SmartbillsClient(new SBClientCredentials { ClientId = "smartbills-plaid", Scopes = new List<string> { "merchants:read", "merchants:create" }, Authority = "http://localhost:5002" }, "https://localhost:44301");
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }


}
