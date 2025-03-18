using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Services.Receipts.Reviews
{
    public record ReceiptReviewUpdateRequest
    {
        public int Rating { get; set; }
        public Dictionary<string, string> Review { get; set; }
    }
}
