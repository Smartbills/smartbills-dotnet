namespace Smartbills.Client
{
    using System;
    using System.Net;

    public class SmartbillsException : Exception
    {
        public SmartbillsException()
        {
        }

        public SmartbillsException(string message)
            : base(message)
        {
        }

        public SmartbillsException(string message, Exception err)
            : base(message, err)
        {
        }

        public SmartbillsException(HttpStatusCode httpStatusCode, SmartbillsException SmartbillsError, string message)
            : base(message)
        {
            this.HttpStatusCode = httpStatusCode;
            this.SmartbillsError = SmartbillsError;
        }

        public HttpStatusCode HttpStatusCode { get; set; }

        public SmartbillsException SmartbillsError { get; set; }

    }
}