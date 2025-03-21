using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Services.Receipts.Reviews
{
    public record ReceiptReviewCreateRequest
    {
        public int Rating { get; set; }
        public string Review { get; set; }
        public Dictionary<string, string> LocalizedReview { get; set; }
    }
}
