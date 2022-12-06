using Smartbills.NET.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Infrastructure
{
    public class SmartbillsErrorResponse
    {

        [JsonPropertyName("status_code")]
        public string StatusCode { get; set; }
        [JsonPropertyName("errors")]
        public List<SmartbillsError> Errors{ get; set; } = new List<SmartbillsError>();
    }
}
