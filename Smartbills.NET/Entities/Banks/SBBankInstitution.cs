using Smartbills.NET.Entities._base;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Banks
{
    public class SBBankInstitution : SmartbillsEntityWithId
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [JsonPropertyName("products")]
        public string Products { get; set; }
        [JsonPropertyName("countries")]
        public string Countries { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("primary_color")]
        public string PrimaryColor { get; set; }
    }
}
