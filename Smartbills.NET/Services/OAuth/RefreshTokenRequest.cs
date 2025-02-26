using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.OAuth
{
    public record RefreshTokenRequest
    {
        [RequestProperty(Name = "client_id")]
        public string ClientId { get; set; }
        [RequestProperty(Name = "client_secret")]
        public string ClientSecret { get; set; }

        [RequestProperty(Name = "refresh_token")]
        public string RefreshToken { get; set; }
    }
}
