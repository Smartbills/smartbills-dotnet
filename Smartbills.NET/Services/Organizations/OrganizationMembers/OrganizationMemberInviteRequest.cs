namespace Smartbills.NET.Services.OrganizationMembers
{
    public record OrganizationMemberInviteRequest
    {
        public long OrganizationId { get; set; }

        public string Email { get; set; }
    }
}
