using System;
using System.Net;

namespace Smartbills.NET
{
    public class SmartbillsException : Exception
    {
        public SmartbillsException(HttpStatusCode statusCode, string message) : base($"{statusCode}, {message}")
        {
        }

    }
}
