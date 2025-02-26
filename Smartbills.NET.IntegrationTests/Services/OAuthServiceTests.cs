using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services.OAuth;
using System.Threading.Tasks;
using Xunit;

namespace Smartbills.NET.IntegrationTests.Services
{

    [Collection("ClientFixture")]
    public class OAuthClientTests
    {
        private readonly IOAuthClient _oauthClient;
        private readonly ClientFixture _clientFixture;
        public OAuthClientTests(ClientFixture clientFixture)
        {
            _clientFixture = clientFixture;
            _oauthClient = new OAuthClient(_clientFixture._client);

        }
        //[Fact]
        //public async Task<SBToken> ShouldGetToken()
        //{
        //    var response = await _oauthClient.GetTokenAsync(new GetTokenRequest
        //    {
        //        ClientId = "smartbills-react-native",
        //        RedirectUri = "io.smartbills.app://auth/login/callback",
        //        GrantType = "authorization_code",
        //        Scope = "offline_access",
        //        Code = "A786438DCED0A2F79856CB53A7CEF6F71E3660D5A875C9FEBB62A22B826A31DF",
        //        CodeVerifier = "ed6da3ac69728104efb7683202eb043715579dc69df0fe8e9667a6d3"
        //    }, default);
        //    Assert.NotNull(response.AccessToken);
        //    return response;
        //}

        //[Fact]
        //public async Task ShouldRefreshToken()
        //{
        //    SBToken token = await ShouldGetToken();
        //    var response = await _oauthClient.RefreshTokenAsync(new RefreshTokenRequest
        //    {
        //        ClientId = "smartbills-react-native",
        //        RefreshToken = token.RefreshToken,
        //    }, default);

        //    Assert.NotNull(response.AccessToken);
        //}
    }
}