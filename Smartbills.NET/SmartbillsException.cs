using Smartbills.NET.Exceptions;
using System;
using System.Collections.Generic;
using System.Net;

namespace Smartbills.NET
{
    public class SmartbillsException : Exception
    {

        public readonly List<SmartbillsError> Errors = new();
        public SmartbillsException(HttpStatusCode statusCode, string message) : base($"{statusCode}, {message}")
        {
        }

        public SmartbillsException(HttpStatusCode statusCode) : base($"Smartbills API returned status code: {statusCode}")
        {
        }
        public SmartbillsException(HttpStatusCode statusCode, List<SmartbillsError> errors) : base($"Smartbills API returned status code: {statusCode}")
        {
            Errors = errors;
        }
    }
}
