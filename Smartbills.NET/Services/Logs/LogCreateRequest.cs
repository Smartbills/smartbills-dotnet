using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Logs
{
    public record LogCreateRequest
    {
        public string RequestId { get; set; }
        public string SessionId { get; set; }
        public string Method { get; set; }
        public string TraceIdentifier { get; set; }
        public int StatusCode { get; set; }
        public string RequestHeaders { get; set; }
        public string RequestBody { get; set; }
        public string ResponseBody { get; set; }
        public string ResponseHeaders { get; set; }
        public long Latency { get; set; }
        public string IPAddress { get; set; }
        public string Url { get; set; }
        public string Query { get; set; }

        public string UserAgent { get; set; }
        public string ClientId { get; set; }
    }
}
