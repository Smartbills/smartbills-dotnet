using Smartbills.NET.Entities.Businesses.Team.Members;

namespace Smartbills.NET.Services.Businesses.Team
{
    public class TeamMemberCreateRequest
    {
        public string Email { get; set; }
        public SBTeamMemberRole Role { get; set; }
        public long BusinessId { get; set; }
    }
}