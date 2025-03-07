
using Smartbills.Core.Models.Organizations;

namespace Smartbills.NET.Services.OrganizationInvitations
{
    public record OrganizationInvitationCreateRequest
    {
        public string Email { get; set; }
        public SBOrganizationMemberRole Role { get; set; } = SBOrganizationMemberRole.Employee;
    }
}
