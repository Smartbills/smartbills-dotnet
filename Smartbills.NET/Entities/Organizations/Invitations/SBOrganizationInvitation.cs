using System;
using Smartbills.Core.Models.Organizations;
using Smartbills.NET.Entities.Users;

namespace Smartbills.NET.Entities.Organization.Invitations
{
    public record SBOrganizationInvitation : SBEntity
    {
        public string Email { get; set; }
        public SBOrganizationMemberRole Role { get; set; }
        public SBOrganizationInvitationStatus Status { get; set; }
        public SBUser InvitedBy { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? CancelledAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
