using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Smartbills.NET.Exceptions
{
    public class SmartbillsAuthenticationException : Exception
    {
        public SmartbillsAuthenticationException()
        {
        }

        public SmartbillsAuthenticationException(string message) : base(message)
        {
        }

        public SmartbillsAuthenticationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SmartbillsAuthenticationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
