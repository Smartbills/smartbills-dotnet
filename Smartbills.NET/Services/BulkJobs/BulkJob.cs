

using System;
using System.Collections.Generic;
using Smartbills.NET.Entities;

namespace Smartbills.NET.Services.BulkJobs
{
    public record BulkJob : SBEntity
    {
        public List<BulkJobItem> Items { get; set; } = new List<BulkJobItem>();
        public Guid SessionId { get; set; }
        public int Count { get; set; } = 0;
        // public SBBulkJobStatus Status { get; set; } = SBBulkJobStatus.Created;
        public DateTimeOffset? StartedAt { get; set; }
        public DateTimeOffset? CompletedAt { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}