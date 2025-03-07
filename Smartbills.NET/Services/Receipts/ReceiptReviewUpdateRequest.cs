using System.Collections.Generic;

namespace Smartbills.NET.Services.Receipts
{
    public record ReceiptReviewUpdateRequest
    {
        public int Rating { get; set; }
        public Dictionary<string, string> Review { get; set; }
    }
}
