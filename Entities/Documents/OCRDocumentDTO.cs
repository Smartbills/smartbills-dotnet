using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Smartbills.Client.Entities;

namespace Smartbills.Client.Entities
{
    public class OCRDocumentDTO : SBDocument
    {

        [JsonPropertyName("ocr_receipt")]
        public SBReceipt OCRReceipt { get; set; }

        [JsonPropertyName("ocr_receipt_id")]
        public Guid? OCRReceiptId { get; set; }

        //[JsonPropertyName("pages")]
        //public List<SBOCRResult> Pages { get; set; }
    }
}
