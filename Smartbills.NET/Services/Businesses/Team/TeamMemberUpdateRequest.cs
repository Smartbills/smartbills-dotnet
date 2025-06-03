using Smartbills.NET.Entities.Businesses.Team.Members;

namespace Smartbills.NET.Services.Businesses.Team
{
    public class TeamMemberUpdateRequest
    {
        public SBTeamMemberRole? Role { get; set; }
        public SBTeamMemberStatus? Status { get; set; }
    }
}