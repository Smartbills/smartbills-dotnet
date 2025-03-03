﻿using Smartbills.NET.Abstractions;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Infrastructure
{
    public record SBToken
    {

        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }
        

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }
        
        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; } = 0;
        
        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }
        
        [JsonPropertyName("scope")]
        public string Scope { get; set; }

    }
}
