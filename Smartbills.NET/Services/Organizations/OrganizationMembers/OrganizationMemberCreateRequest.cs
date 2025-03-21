using Smartbills.NET.Entities.Organizations.Members;

namespace Smartbills.NET.Services.Organizations.OrganizationMembers
{
    public record OrganizationMemberCreateRequest
    {
        public SBOrganizationMemberRole Role { get; set; } = SBOrganizationMemberRole.Employee;
    }
}
