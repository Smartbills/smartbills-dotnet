using Smartbills.NET.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Infrastructure
{
    public class SmartbillsErrorResponse
    {

        
        public string StatusCode { get; set; }
        
        public List<SmartbillsError> Errors{ get; set; } = new List<SmartbillsError>();
    }
}
