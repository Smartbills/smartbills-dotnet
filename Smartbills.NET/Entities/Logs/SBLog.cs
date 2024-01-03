using System;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Logs
{
    public record SBLog
    {
        public string SessionId { get; set; }
        public string RequestId { get; set; }
        public string Method { get; set; }
        public string TraceIdentifier { get; set; }
        public int StatusCode { get; set; }
        public string RequestHeaders { get; set; }
        public string RequestBody { get; set; }
        public string ResponseBody { get; set; }
        public string ResponseHeaders { get; set; }
        public long Latency { get; set; }
        public string IPAddress { get; set; }
        public DateTimeOffset Timestamp { get; set; }
        public string Url { get; set; }
        public string Query { get; set; }
        public string UserAgent { get; set; }
        public string ClientId { get; set; }
        public long? UserId { get; set; }

        public long? MerchantId { get; set; }
    }
}
