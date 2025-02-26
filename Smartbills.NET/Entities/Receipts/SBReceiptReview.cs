using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Entities.Receipts
{

    public record SBReceiptReview : SmartbillsEntityWithId
    {
        public int Rating { get; set; }
        public string Review { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
