
using Newtonsoft.Json;
using RestSharp;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Merchants;
using Smartbills.NET.Services;
using Smartbills.NET.Services.Merchants;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Smartbills.NET.IntegrationTests.Services
{

    [Collection("ClientFixture")]
    public class MerchantClientTest
    {
        private readonly ClientFixture _clientFixture;
        private readonly IMerchantClient _merchantClient;
        public MerchantClientTest(ClientFixture clientFixture)
        {
            _clientFixture = clientFixture;
            _merchantClient = new MerchantClient(_clientFixture._client);

        }
        [Fact]
        public async Task SHOULD_CREATE_MERCHANT()
        {
            var merchant = new SBMerchant()
            {
                Name = "Smartbills Technologies Inc.",
            };
            await Assert.ThrowsAnyAsync<Exception>(() => _merchantClient.CreateAsync(new CreateMerchantRequest(), default));
        }

        [Fact]
        public async Task SHOULD_GET_MERCHANT_BY_ID()
        {
            var merchant = new SBMerchant();
            var response = await _merchantClient.GetByIdAsync(new long(), default);
            Assert.Equal(merchant, response);
        }

        [Fact]
        public async Task SHOULD_NOT_FIND_MERCHANT()
        {
            var merchant = new SBMerchant();
            var response = await _merchantClient.GetByIdAsync(-1, default);
            Assert.Equal(merchant, response);
        }
    }
}