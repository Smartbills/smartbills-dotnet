using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.OAuth
{
    public record AuthorizeRequest
    {
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        [JsonPropertyName("redirect_uri")]
        public string RedirectUri { get; set; }

        [JsonPropertyName("response_type")]
        public string ResponseType { get; set; }

        [JsonPropertyName("code_challenge")]
        public string CodeChallenge { get; set; }

        [JsonPropertyName("code_challenge_method")]
        public string CodeChallengeMethod { get; set; }

        [JsonPropertyName("grant")]
        public string Grant { get; set; }

        [JsonPropertyName("response_mode")]
        public string ResponseMode { get; set; }

        [JsonPropertyName("scope")]
        public string Scope { get; set; }
    }
}
