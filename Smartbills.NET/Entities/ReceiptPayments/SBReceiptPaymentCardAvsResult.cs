using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Smartbills.NET.Entities.ReceiptPayments
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
