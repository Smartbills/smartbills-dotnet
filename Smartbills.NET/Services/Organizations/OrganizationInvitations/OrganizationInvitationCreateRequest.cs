using Smartbills.NET.Entities.Organizations.Members;

namespace Smartbills.NET.Services.Organizations.OrganizationInvitations
{
    public record OrganizationInvitationCreateRequest
    {
        public string Email { get; set; }
        public SBOrganizationMemberRole Role { get; set; } = SBOrganizationMemberRole.Employee;
    }
}
