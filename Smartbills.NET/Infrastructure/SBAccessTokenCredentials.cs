using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Infrastructure
{
    public class SBAccessTokenCredentials: SBCredentials
    {
        public SBAccessTokenCredentials(string accessToken, string refreshToken = null)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }

        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
