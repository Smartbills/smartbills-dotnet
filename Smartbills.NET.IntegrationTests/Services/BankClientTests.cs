
using Newtonsoft.Json;
using RestSharp;
using Smartbills.NET.Entities;
using Smartbills.NET.IntegrationTests;
using Smartbills.NET.Services;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Smartbills.NET.IntegrationTests
{

    [Collection("ClientFixture")]
    public class BankClientTest
    {
        private readonly ClientFixture _clientFixture;
        private readonly IBankClient _bankClient;
        public BankClientTest(ClientFixture clientFixture)
        {
            _clientFixture = clientFixture;
            _bankClient = new BankClient(_clientFixture._client);

        }
        [Fact]
        public async Task SHOULD_FIND_BANK()
        {
            var bank = new SBBank();
            var response = await _bankClient.GetByIdAsync(new long(),  default);
            Assert.Equal(bank, response);
        }

        [Fact]
        public async Task SHOULD_R()
        {
            var bank = new SBBank();
            var response = await _bankClient.GetByIdAsync(new long(),  default);
            Assert.Equal(bank, response);
        }
    }
}