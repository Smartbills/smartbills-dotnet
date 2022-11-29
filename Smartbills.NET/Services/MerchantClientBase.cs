using Smartbills.NET.Infrastructure;

namespace Smartbills.NET.Services
{

    public interface IMerchantClientBase
    {
        void SetMerchantId(long? merchantId);
    }
    public class MerchantClientBase<T> : ClientBase<T>, IMerchantClientBase
    {
        public MerchantClientBase(ISmartbillsClient smartbills) : base(smartbills)
        {
        }

        public MerchantClientBase(long merchantId, SBClientCredentials credentials, string url = "https://api.smartbills.io") : base(credentials, url)
        {
            SetMerchantId(merchantId);
        }

        public MerchantClientBase(long merchantId, string accessToken, string url = "https://api.smartbills.io") : base(accessToken, url)
        {
            SetMerchantId(merchantId);
        }

        public MerchantClientBase(long merchantId, string apiKey, string apiSecret, string url = "https://api.smartbills.io") : base(apiKey, apiSecret, url)
        {
            SetMerchantId(merchantId);
        }

        public void SetMerchantId(long? merchantId)
        {
            base._smartbillsClient.SetMerchantId(merchantId);

        }
    }
}
