﻿using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.Json;
using Smartbills.NET.Entities;
using Smartbills.NET.Exceptions;
using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services.Banks;
using Smartbills.NET.Services.Merchants;
using Smartbills.NET.Services.Receipts;
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Linq;
using System.Text.Json.Serialization;
using System.Globalization;

namespace Smartbills.NET.Infrastructure
{
    public interface ISmartbillsClient
    {
        public RestClient ApiClient { get; set; }
        public RestClient AuthClient { get; set; }
    }

    public interface SBCredentials { }

    public class SBEndpoints
    {
        public string Url { get; set; } = "https://api.smartbills.io/";
        public string AuthUrl { get; set; } = "https://api.smartbills.io/auth";
    }
    public class SmartbillsClientOption
    {
        public SBCredentials Credentials { get; set; }
        public SBEndpoints Endpoints { get; set; } = new SBEndpoints();
        public string SessionId { get; set; } = Guid.NewGuid().ToString();
        public string Locale { get; set; } = "en-CA";
    }


    public class SmartbillsClient : ISmartbillsClient, IDisposable
    {
        public RestClient ApiClient { get; set; }
        public RestClient AuthClient { get; set; }
        public SmartbillsClientOption Options { get; set; }


        public SmartbillsClient(SmartbillsClientOption options = null)
        {
            Options = options ?? new SmartbillsClientOption();
            ApiClient = CreateClient(Options.Endpoints.Url);
            AuthClient = CreateClient(Options.Endpoints.AuthUrl);

        }

        protected RestClient CreateClient(string url)
        {

            var version = typeof(SmartbillsClient).GetTypeInfo().Assembly.GetName().Version;

            RestClientOptions restClientOptions = new(url)
            {
                ThrowOnAnyError = true,
                ThrowOnDeserializationError = true,
                FailOnDeserializationError = true,
                UserAgent = "Smartbills.NET v" + version,
                Authenticator = GetAuthenticator(Options),
            };


            var client = new RestClient(restClientOptions, configureSerialization: s =>
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                };
                options.Converters.Add(new JsonStringEnumConverter());

                s.UseSystemTextJson(options);
                }
);
            client.AddDefaultHeader("X-Session-Id", Options.SessionId);
            client.AddDefaultHeader("Accept-Language", Options.Locale);

            return client;
        }

        private IAuthenticator GetAuthenticator(SmartbillsClientOption options)
        {
            switch (options.Credentials)
            {
                case SBClientCredentials credentials:
                    return new SBClientCredentialsAuthenticator(credentials);

                case SBApiKeyCredentials credentials:
                    return new ApiKeyAuthenticator(credentials);

                case SBAccessTokenCredentials credentials:
                    return new JwtAuthenticator(credentials.AccessToken);

                default:
                    return null;
            }
        }

        public void Dispose()
        {
            ApiClient.Dispose();
        }


    }

}