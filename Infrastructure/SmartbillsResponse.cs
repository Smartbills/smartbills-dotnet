using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Smartbills.Client
{
    public class SmartbillsResponse<T>  
    {
        public T Data { get; set; }
        public SmartbillsResponse(HttpResponseMessage response, string content)
        {
            StatusCode = response.StatusCode;
            IsSuccessStatusCode = response.IsSuccessStatusCode;
            Headers = response.Headers;
            this.Content = content;
        }

        public HttpStatusCode StatusCode { get; }
        public HttpResponseHeaders Headers { get; }
        public bool IsSuccessStatusCode { get; }
        public string Content { get; }
    }
}