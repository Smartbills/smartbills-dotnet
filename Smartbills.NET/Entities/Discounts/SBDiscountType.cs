using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Discounts
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SBDiscountType
    {
        
        [EnumMember(Value = "percentage")]
        PERCENTAGE,
        
        [EnumMember(Value = "amount")]
        AMOUNT,
    }
}
