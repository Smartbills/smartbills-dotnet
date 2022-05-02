using System.Text.Json.Serialization;

namespace Smartbills.Client.Entities
{
    public class SBBrowserMetadata
    {
        [JsonPropertyName("accept_language")]
        public string AcceptLanguage { get; set; }
        [JsonPropertyName("browser_height")]
        public long BrowserHeight { get; set; }
        [JsonPropertyName("browser_ip")]
        public string BrowserIp { get; set; }

        [JsonPropertyName("browser_width")]
        public long BrowserWidth { get; set; }
        [JsonPropertyName("session_hash")]
        public string SessionHash { get; set; }
        [JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
    }
}
