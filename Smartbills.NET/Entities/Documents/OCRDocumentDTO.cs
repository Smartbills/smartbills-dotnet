using Smartbills.NET.Entities.Receipts;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Documents
{
    public record OCRDocumentDTO : SBDocument
    {

        
        public SBReceipt OCRReceipt { get; set; }

        
        public long? OCRReceiptId { get; set; }

        //
        //public List<SBOCRResult> Pages { get; set; }
    }
}
