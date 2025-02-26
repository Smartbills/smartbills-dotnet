using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Settings
{
    public record UserNotificationSettingDTO
    {
        
        public bool PushNewBankTransaction { get; set; } = true;

        
        public bool PushNewReceipt { get; set; } = true;
        
        public bool EmailNewsletter { get; set; } = true;
        
        public bool EmailProductUpdate { get; set; } = true;
        
        public bool EmailTools { get; set; } = true;
        
        public bool EmailCommunity { get; set; } = true;
    }
}
