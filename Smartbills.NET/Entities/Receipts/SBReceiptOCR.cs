
namespace Smartbills.NET.Entities.Receipts
{
    public record SBReceiptOCR : SBReceipt, ITimestamp
    {
        public SBReceiptOCR()
        {
        }

        public SBReceiptAccuracy Accuracy { get; set; }
    }
}
