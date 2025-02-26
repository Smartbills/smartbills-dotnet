using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Settings
{
    public record UserAccountSettingDTO
    {
        
        public string DisplayLanguage { get; set; }

        
        public string CommunicationLanguage { get; set; }
    }
}
