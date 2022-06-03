using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Transactions.CreditCards
{
    public class CreateCreditCardDTO
    {
        [Required]
        [StringLength(6, MinimumLength = 6)]
        [JsonPropertyName("bin")]
        public string Bin { get; set; }
        [Required]
        [StringLength(4, MinimumLength = 4)]
        [JsonPropertyName("last_4")]
        public string Last4 { get; set; }
        [Required]
        [JsonPropertyName("company")]
        public string Company { get; set; }
    }
}
