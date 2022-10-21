using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Settings
{
    public record UserAccountSettingDTO
    {
        [JsonPropertyName("display_language")]
        public string DisplayLanguage { get; set; }

        [JsonPropertyName("communication_language")]
        public string CommunicationLanguage { get; set; }
    }
}
