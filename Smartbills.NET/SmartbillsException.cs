using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET
{
    public class SmartbillsException : Exception
    {
        public SmartbillsException(HttpStatusCode statusCode, string message) : base($"{statusCode}, {message}")
        {
        }

    }
}
