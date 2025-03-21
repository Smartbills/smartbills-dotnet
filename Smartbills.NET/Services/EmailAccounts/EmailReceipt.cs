using System;

namespace Smartbills.NET.Services.EmailAccounts
{
    public class SBEmailAccountReceipt
    {
        public string RecipientEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTimeOffset SentDate { get; set; }

        public SBEmailAccountReceipt(string recipientEmail, string subject, string body, DateTimeOffset sentDate)
        {
            RecipientEmail = recipientEmail;
            Subject = subject;
            Body = body;
            SentDate = sentDate;
        }
    }
}