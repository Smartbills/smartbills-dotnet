using System;
using Smartbills.NET.Entities.Users;

namespace Smartbills.NET.Entities.Businesses.Team.Members
{
    public record SBTeamMember : SBEntity, ITimestamp
    {
        public SBTeamMemberRole Role { get; set; }
        public SBUser User { get; set; }
        public SBTeamMemberStatus Status { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}