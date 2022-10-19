
using Newtonsoft.Json;
using RestSharp;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Locations;
using Smartbills.NET.Services;
using Smartbills.NET.Services.Locations;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Smartbills.NET.IntegrationTests.Services
{

    [Collection("ClientFixture")]
    public class LocationClientTests
    {
        private readonly ClientFixture _clientFixture;
        private readonly ILocationClient _locationClient;
        public LocationClientTests(ClientFixture clientFixture)
        {
            _clientFixture = clientFixture;
            _locationClient = new LocationClient(_clientFixture._client);

        }
        [Fact]
        public async Task SHOULD_FIND_LOCATION()
        {
            var bank = new SBLocation();
            var response = await _locationClient.GetByIdAsync(new long(), default);
            Assert.Equal(bank, response);
        }

        [Fact]
        public async Task SHOULD_R()
        {
            var bank = new SBLocation();
            var response = await _locationClient.GetByIdAsync(new long(), default);
            Assert.Equal(bank, response);
        }
    }
}