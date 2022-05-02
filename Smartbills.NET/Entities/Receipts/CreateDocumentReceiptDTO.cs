using System;
using System.Text.Json.Serialization;

namespace Smartbills.Client.Entities
{
    public class CreateDocumentReceiptDTO
    {
        [JsonPropertyName("company_id")]
        public long? CompanyId { get; set; }

        //[JsonPropertyName("items")]
        //public List<CreateReceiptItemDTO> Items { get; set; } = new List<CreateReceiptItemDTO>();
        [JsonPropertyName("currency")]
        public string Currency { get; set; }
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        //public List<CreateReceiptTaxRequest> Taxes { get; set; } = new List<CreateReceiptTaxRequest>();
        [JsonPropertyName("taxes_included")]

        public bool TaxesIncluded { get; set; }
        [JsonPropertyName("total_tip")]

        public decimal TotalTip { get; set; }
        [JsonPropertyName("total_duties")]

        public decimal TotalDuties { get; set; }
        [JsonPropertyName("total_shipping")]

        public decimal TotalShipping { get; set; }
        [JsonPropertyName("total_weight")]

        public decimal TotalWeight { get; set; }
        [JsonPropertyName("total_taxes")]

        public decimal TotalTaxes { get; set; }
        [JsonPropertyName("total")]

        public decimal Total { get; set; }

        [JsonPropertyName("subtotal")]

        public decimal SubTotal { get; set; }

        [JsonPropertyName("store_id")]

        public long? StoreId { get; set; }

        //[JsonPropertyName("barcode")]
        //public CreateBarcodeDTO Barcode { get; set; }
    }
}
