using System.Collections.Generic;

namespace Smartbills.NET.Services.Receipts
{
    public record ReceiptReviewCreateRequest
    {
        public int Rating { get; set; }
        public string Review { get; set; }
        public Dictionary<string, string> LocalizedReview { get; set; }
    }
}
