using System;

namespace Smartbills.NET.Entities.Receipts
{

    public record SBReceiptReview : SBEntity
    {
        public int Rating { get; set; }
        public string Review { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
