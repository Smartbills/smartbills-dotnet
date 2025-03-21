using System.Collections.Generic;
namespace Smartbills.NET.Services.Webhooks
{
    public class WebhookUpdateRequest
    {
        public string Url { get; set; }
        public List<string> Events { get; set; }
        public bool IsActive { get; set; }
    }
}
