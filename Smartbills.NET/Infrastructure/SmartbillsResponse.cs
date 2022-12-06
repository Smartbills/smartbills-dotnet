using Smartbills.NET.Exceptions;
using System.Collections.Generic;
using System.Net;

namespace Smartbills.NET.Infrastructure
{
    public class SmartbillsResponse<TResponse>
    {
        public SmartbillsResponse(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }
        public SmartbillsResponse(HttpStatusCode statusCode, TResponse data)
        {
            StatusCode = statusCode;
            Data = data;
            IsSuccessful = true;
        }

        public SmartbillsResponse(HttpStatusCode statusCode, List<SmartbillsError> errors)
        {
            StatusCode = statusCode;
            Errors = errors;
            IsSuccessful = false;
        }

        public TResponse Data { get; set; }

        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccessful { get; set; }
        public List<SmartbillsError> Errors { get; set; } = new List<SmartbillsError>();
    }
}
