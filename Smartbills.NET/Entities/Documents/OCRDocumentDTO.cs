using System;
using System.Text.Json.Serialization;

namespace Smartbills.Client.Entities
{
    public class OCRDocumentDTO : SBDocument
    {

        [JsonPropertyName("ocr_receipt")]
        public SBReceipt OCRReceipt { get; set; }

        [JsonPropertyName("ocr_receipt_id")]
        public long? OCRReceiptId { get; set; }

        //[JsonPropertyName("pages")]
        //public List<SBOCRResult> Pages { get; set; }
    }
}
