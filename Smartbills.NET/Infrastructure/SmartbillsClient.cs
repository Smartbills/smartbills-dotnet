using Microsoft.Extensions.Options;
using Smartbills.Client.Services;
using Smartbills.Infrastructure;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client
{
    public interface ISmartbillsClient
    {
        public virtual string APIVersion => "v1";

        void SetUrl(string url);
        Task<SmartbillsResponse<T>> RequestAsync<T, TRequest>(
                  HttpMethod method,
                  string path,
                  TRequest options,
                  RequestOptions requestOptions,
                  HttpContent content = null,
                  CancellationToken cancellationToken = default);
    }
    public class SmartbillsClient : ISmartbillsClient
    {
        private readonly SmartbillsConfiguration _configuration;
        private readonly HttpClient _client;

        public string ApiUrl => _client.BaseAddress.ToString();

        public string SmartbillsClientUserAgent => BuildSmartbillsClientUserAgentString();

        public SmartbillsClient(HttpClient client, IOptions<SmartbillsConfiguration> configuration)
        {
            _client = client;
            _configuration = configuration.Value;
        }


        public async Task<SmartbillsResponse<T>> RequestAsync<T, TRequest>(
                HttpMethod method,
                string path,
                TRequest options,
                RequestOptions requestOptions = null,
                HttpContent httpContent = null,
                CancellationToken cancellationToken = default)
        {
            var request = new SmartbillsRequest<TRequest>(this, method, path, options, requestOptions, httpContent);
            var response = await SendHttpRequest(request, cancellationToken);
            return await ProcessResponse<T>(response);
        }




        private async Task<SmartbillsResponse<T>> ProcessResponse<T>(HttpResponseMessage response)
        {
            var body = await response.Content.ReadAsStringAsync();
            SmartbillsResponse<T> smartbillsResponse = new(response, body);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                throw BuildSmartbillsException(smartbillsResponse);
            }

            if (body != null)
            {

                smartbillsResponse.Data = GenericParser.Parse<T>(body);
            }

            return smartbillsResponse;
        }


        private async Task<HttpResponseMessage> SendHttpRequest<TRequest>(SmartbillsRequest<TRequest> request, CancellationToken cancellationToken = default)
        {
            var httpRequest = BuildRequestMessage(request);
            HttpResponseMessage response = await _client.SendAsync(httpRequest, cancellationToken);
            return response;
        }

        private HttpRequestMessage BuildRequestMessage<TRequest>(SmartbillsRequest<TRequest> request)
        {
            var requestMessage = new System.Net.Http.HttpRequestMessage(request.Method, request.Uri);

            requestMessage.Content = request.Content;
            return requestMessage;
        }

        private string BuildSmartbillsClientUserAgentString()
        {
            var values = new Dictionary<string, object>
            {
                { "lang", ".net" },
                { "publisher", "smartbills" },
            };
            try
            {
                values.Add("lang_version", System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription);
            }
            catch (Exception)
            {
                values.Add("lang_version", "(unknown)");
            }

            try
            {
                values.Add("os_version", System.Environment.OSVersion);
            }
            catch (Exception)
            {
                values.Add("os_version", "(unknown)");
            }

            return JsonSerializer.Serialize(values);
        }

        private static SmartbillsException BuildSmartbillsException<T>(SmartbillsResponse<T> response)
        {
            return new SmartbillsException(
                    response.StatusCode,
                    null,
                  response.Content);
            //try
            //    {
            //        var smartbillsError = JsonSerializer.Deserialize<SmartbillsError>(response.Content);

            //        return new SmartbillsException(
            //            response.StatusCode,
            //            smartbillsError,
            //            smartbillsError.Message);
            //    }
            //    catch (Exception)
            //    {
            //        return BuildInvalidResponseException(response);
            //    }
        }
        public void SetUrl(string url)
        {
            _client.BaseAddress = new Uri(url);
        }
    }
}