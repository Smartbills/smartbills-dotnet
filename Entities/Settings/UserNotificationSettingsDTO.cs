using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Smartbills.Client.Entities.Settings
{
    public class UserNotificationSettingDTO
    {
        [JsonPropertyName("push_new_bank_transaction")]
        public bool PushNewBankTransaction { get; set; } = true;

        [JsonPropertyName("push_new_receipt")]
        public bool PushNewReceipt { get; set; } = true;
        [JsonPropertyName("email_newsletter")]
        public bool EmailNewsletter { get; set; } = true;
        [JsonPropertyName("email_product_update")]
        public bool EmailProductUpdate { get; set; } = true;
        [JsonPropertyName("email_tools")]
        public bool EmailTools { get; set; } = true;
        [JsonPropertyName("email_community")]
        public bool EmailCommunity { get; set; } = true;
    }
}
