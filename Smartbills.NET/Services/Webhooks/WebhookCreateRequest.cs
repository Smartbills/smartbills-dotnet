using System.Collections.Generic;

namespace Smartbills.NET.Services.Webhooks
{
    public class WebhookCreateRequest
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public List<string> Events { get; set; } = new();
        public bool IsActive { get; set; } = true;
    }
}
