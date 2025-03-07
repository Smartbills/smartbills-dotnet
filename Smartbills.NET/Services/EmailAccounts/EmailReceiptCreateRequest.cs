using System.Collections.Generic;

namespace Smartbills.NET.Services.EmailAccounts
{
    public class EmailReceiptCreateRequest
    {
        public string RecipientEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<string> Attachments { get; set; }

        public EmailReceiptCreateRequest()
        {
            Attachments = new List<string>();
        }
    }
}