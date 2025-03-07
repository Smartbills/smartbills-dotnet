using System;
using System.Collections.Generic;

namespace Smartbills.NET.Services.EmailAccounts
{
    public record EmailAccountOAuth2CreateRequest
    {
        public string Provider { get; set; }
        public string Email { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string IdToken { get; set; }
        public List<string> Scopes { get; set; }
        public DateTimeOffset ExpiresAt { get; set; }
    }
}