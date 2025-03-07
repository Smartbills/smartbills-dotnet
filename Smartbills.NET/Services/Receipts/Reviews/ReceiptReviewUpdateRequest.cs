using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Services.ReceiptReviews
{
    public record ReceiptReviewUpdateRequest
    {
        public int Rating { get; set; }
        public Dictionary<string, string> Review { get; set; }
    }
}
