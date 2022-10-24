using Smartbills.NET.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Services
{
    public class MerchantClientBase<T> : ClientBase<T>
    {
        public MerchantClientBase(ISmartbillsClient smartbills) : base(smartbills)
        {
        }

        public MerchantClientBase(SBClientCredentials credentials) : base(credentials)
        {
        }

        public MerchantClientBase(string accessToken, string url = "https://api.smartbills.io") : base(accessToken, url)
        {
        }

        public MerchantClientBase(string apiKey, string apiSecret, string url = "https://api.smartbills.io") : base(apiKey, apiSecret, url)
        {
        }

        public void  SetMerchantId(string merchantId) {
            base._smartbills.SetMerchantId(merchantId);

        }
    }
}
