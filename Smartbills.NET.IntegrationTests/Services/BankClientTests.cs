//using Smartbills.NET.Entities.Banks;
//using Smartbills.NET.Services.Banks;
//using System.Threading.Tasks;
//using Xunit;

//namespace Smartbills.NET.IntegrationTests.Services
//{

//    [Collection("ClientFixture")]
//    public class BankClientTest
//    {
//        private readonly ClientFixture _clientFixture;
//        private readonly IBankClient _bankClient;
//        public BankClientTest(ClientFixture clientFixture)
//        {
//            _clientFixture = clientFixture;
//            _bankClient = new BankClient(_clientFixture._client);

//        }
//        [Fact]
//        public async Task SHOULD_FIND_BANK()
//        {
//            var bank = new SBBank();
//            var response = await _bankClient.GetByIdAsync(new long(), default);
//            Assert.Equal(bank, response);
//        }

//        [Fact]
//        public async Task SHOULD_R()
//        {
//            var bank = new SBBank();
//            var response = await _bankClient.GetByIdAsync(new long(), default);
//            Assert.Equal(bank, response);
//        }
//    }
//}