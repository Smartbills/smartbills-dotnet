
using System;
using Smartbills.Core.Models.Organizations;
using Smartbills.NET.Entities.Users;

namespace Smartbills.NET.Entities.Organizations
{
    public record SBOrganizationMember : SBEntity, ITimestamp
    {
        public SBOrganizationMemberRole Role { get; set; }
        public SBUser User { get; set; }
        public SBOrganizationMemberStatus Status { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
