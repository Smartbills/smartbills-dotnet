using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Exceptions
{
    public class SmartbillsError
    {

        
        public string Code { get; set; }
        
        public string Message { get; set; }
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Parameter { get; set; }
    }
}
