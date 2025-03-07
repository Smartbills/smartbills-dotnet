using Smartbills.Core.Models.Organizations;

namespace Smartbills.NET.Services.OrganizationMembers
{
    public record OrganizationMemberCreateRequest
    {
        public SBOrganizationMemberRole Role { get; set; } = SBOrganizationMemberRole.Employee;
    }
}
