using Smartbills.Client.Services;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Text.Json;

namespace Smartbills.Client
{
    public class SmartbillsRequest<T>
    {
        public SmartbillsRequest(
            SmartbillsClient client,
            HttpMethod method,
            string path,
            T options,
            RequestOptions requestOptions,
            HttpContent content = null)
        {
            Request = options;
            Method = method;
            RequestOptions = requestOptions;
            Uri = BuildUri(client, method, path, options);
            if (content == null)
            {
                Content = BuildContent(Method, options);
            }
            else
            {
                Content = content;
            }
            // AuthorizationHeader = BuildAuthorizationHeader(client);
        }

        public T Request { get; }
        public RequestOptions RequestOptions { get; }

        public HttpMethod Method { get; }

        /// <summary>
        /// The URL for the request. If this is a GET or DELETE request, the URL also includes
        /// the request parameters in its query string.
        /// </summary>
        public Uri Uri { get; }

        /// <summary>The value of the <c>Authorization</c> header with the API key.</summary>
        public AuthenticationHeaderValue AuthorizationHeader { get; }

        public HttpContent Content { get; set; }

        public override string ToString()
        {
            return string.Format(
                "<{0} Method={1} Uri={2}>",
                this.GetType().FullName,
                this.Method,
                this.Uri.ToString());
        }


        private static Uri BuildUri(
                           SmartbillsClient client,
                           HttpMethod method,
                           string path,
                           T options


                           )
        {
            var b = new StringBuilder();

            b.Append(client.ApiUrl);
            b.Append(path);

            if ((method != HttpMethod.Post) && (options != null))
            {
                var queryString = UrlHelpers.ToQueryString(options);
                if (!string.IsNullOrEmpty(queryString))
                {
                    b.Append("?");
                    b.Append(queryString);
                }
            }

            return new Uri(b.ToString());
        }


        private static HttpContent BuildContent<TRequest>(HttpMethod method, TRequest options)
        {
            if (method != HttpMethod.Post && method != HttpMethod.Put)
            {
                return null;
            }

            var serializeRequest = new JsonSerializerOptions
            {
                IncludeFields = true,
            };
            var json = System.Text.Json.JsonSerializer.Serialize(options, options.GetType(), serializeRequest);

            return new StringContent(json, UnicodeEncoding.UTF8, MediaTypeNames.Application.Json);

        }
    }
}