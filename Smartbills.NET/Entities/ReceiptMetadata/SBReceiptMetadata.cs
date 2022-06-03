using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities
{
    public class SBReceiptMetadata
    {
        [JsonPropertyName("landing_site")]

        public string LandingSite { get; set; }
        [JsonPropertyName("customer_locale")]
        public string CustomerLocale { get; set; }

        [JsonPropertyName("reffering_site")]
        public string RefferingSite { get; set; }

        [JsonPropertyName("source_pos")]
        public string SourcePOS { get; set; }

        [JsonPropertyName("source_name")]
        public string SourceName { get; set; }

        [JsonPropertyName("tags")]
        public string Tags { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("browser_metadata")]
        public SBBrowserMetadata BrowserMetadata { get; set; }
    }
}
