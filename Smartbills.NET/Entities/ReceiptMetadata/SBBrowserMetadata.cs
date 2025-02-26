using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.ReceiptMetadata
{
    public record SBBrowserMetadata
    {
        
        public string AcceptLanguage { get; set; }
        
        public long BrowserHeight { get; set; }
        
        public string BrowserIp { get; set; }

        
        public long BrowserWidth { get; set; }
        
        public string SessionHash { get; set; }
        
        public string UserAgent { get; set; }
    }
}
