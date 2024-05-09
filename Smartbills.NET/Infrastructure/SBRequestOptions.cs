using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Infrastructure
{
    public class SBRequestOptions
    {
        public string AccessToken { get; set; }
        public long MerchantId { get; set; }
    }
}
