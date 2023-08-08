using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.OAuth
{
    public record GetTokenRequest
    {

        [RequestProperty(Name ="client_id")]
        public string ClientId { get; set; }
        [RequestProperty (Name="client_secret")]
        public string ClientSecret { get; set; }

        [RequestProperty (Name="grant_type")]
        public string GrantType { get; set; }

        [RequestProperty (Name="refresh_token")]
        public string RefreshToken { get; set; }
        [RequestProperty (Name="code")]

        public string Code {get;set ;}
        [RequestProperty (Name="redirect_uri")]
        public string RedirectUri { get;set ; }
        [RequestProperty (Name="code_verifier")]
        public string CodeVerifier { get; set ; }
        [RequestProperty (Name="scope")]
        public string Scope { get;set ; }
        [RequestProperty (Name="acr_values")]
        public string AcrValues { get;set ; }
        [RequestProperty (Name="device_code")]
        public string DeviceCode { get; set ; }
    }
}
