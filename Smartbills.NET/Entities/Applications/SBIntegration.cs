using System;

namespace Smartbills.NET.Entities.Applications
{
    public record SBIntegration : SBEntity
    {
        // public SBMarketplaceApp Application { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    }
}