using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Exceptions
{
    public  class SmartbillsApiException :Exception
    {
        public SmartbillsApiException(HttpStatusCode statusCode, List<SmartbillsError> errors) : base($"Smartbills API request failed status code: {(int)statusCode}")
        {
            StatusCode = statusCode;
            Errors = errors;
        }

        public SmartbillsApiException(HttpStatusCode statusCode) : base($"Smartbills API request failed status code: {(int)statusCode}")
        {
            StatusCode = statusCode;
        }

        
        public HttpStatusCode StatusCode { get; set; }
        
        public  List<SmartbillsError> Errors { get; set; } = new();
    }
}
