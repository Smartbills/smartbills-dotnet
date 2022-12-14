using Smartbills.NET.Infrastructure;

namespace Smartbills.NET.Services
{

    public interface IUserClientBase
    {
        void SetAccessToken(string accessToken);
    }
    public class UserClientBase<T> : ClientBase<T>, IUserClientBase
    {
        public UserClientBase(ISmartbillsClient smartbillsClient) : base(smartbillsClient)
        {
        }
        public UserClientBase(string accessToken, string url = "https://api.smartbills.io") : base(accessToken, url)
        {
        }

        public void SetAccessToken(string accessToken)
        {
            _smartbillsClient.SetAccessToken(accessToken);
        }
    }
}
