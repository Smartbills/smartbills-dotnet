using Smartbills.Core.Models.Organizations;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Users;
using System;

namespace Smartbills.NET.Entities.Organizations
{
    public record SBOrganization : SBEntity, ITimestamp
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Logo { get; set; }
        public string PlanId { get; set; }
        public SBUser Owner { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
