using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.OAuth
{
    public record AuthorizeRequest
    {
        
        public string ClientId { get; set; }

        
        public string RedirectUri { get; set; }

        
        public string ResponseType { get; set; }

        
        public string CodeChallenge { get; set; }

        
        public string CodeChallengeMethod { get; set; }

        
        public string Grant { get; set; }

        
        public string ResponseMode { get; set; }

        
        public string Scope { get; set; }
    }
}
