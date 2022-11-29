using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Discounts
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SBDiscountType
    {
        [JsonPropertyName("percentage")]
        [EnumMember(Value = "percentage")]
        PERCENTAGE,
        [JsonPropertyName("amount")]
        [EnumMember(Value = "amount")]
        AMOUNT,
    }
}
