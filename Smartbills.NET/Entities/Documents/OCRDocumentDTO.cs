using Smartbills.NET.Entities.Receipts;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Documents
{
    public record OCRDocumentDTO : SBDocument
    {

        [JsonPropertyName("ocr_receipt")]
        public SBReceipt OCRReceipt { get; set; }

        [JsonPropertyName("ocr_receipt_id")]
        public long? OCRReceiptId { get; set; }

        //[JsonPropertyName("pages")]
        //public List<SBOCRResult> Pages { get; set; }
    }
}
