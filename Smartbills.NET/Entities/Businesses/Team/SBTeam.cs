using System;
using System.Collections.Generic;
using Smartbills.NET.Entities.Businesses.Team.Members;

namespace Smartbills.NET.Entities.Businesses.Team
{
    public record SBTeam : SBEntity, ITimestamp
    {
        public string Name { get; set; }
        public long BusinessId { get; set; }
        public List<SBTeamMember> Members { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}