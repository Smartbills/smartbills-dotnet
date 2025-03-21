using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Receipts.Payments
{

    public enum SBReceiptPaymentCardAvsResult
    {
        [JsonPropertyName("A")]
        PostalCodeAddressMatched,
        [JsonPropertyName("B")]
        PostalCodeMatchedAddressNotChecked,
        [JsonPropertyName("C")]
        PostalCodeMatchedAddressNotMatched,
        [JsonPropertyName("D")]
        AddressMatchedPostalCodeNotChecked,
        [JsonPropertyName("E")]
        PostalCodeAddressNotChecked,
        [JsonPropertyName("F")]
        AddressMatchedPostalCodeNotMatched,
        [JsonPropertyName("G")]
        PostalCodeNotCheckedAddressNotMatched,
        [JsonPropertyName("H")]
        PostalCodeAddressNotSupplied,
        [JsonPropertyName("I")]
        AddressNotCheckedPostalCodeNotMatched,
        [JsonPropertyName("J")]
        PostalCodeAddressNotMatched
    }
}
