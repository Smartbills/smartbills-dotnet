using System;

namespace Smartbills.NET.Entities.Reviews
{
    public record SBReview : SBEntity, ITimestamp
    {
        public int Rating { get; set; }
        public string Review { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}