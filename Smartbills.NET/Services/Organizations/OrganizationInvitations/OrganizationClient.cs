using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Organizations.Invitations;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Organizations.OrganizationInvitations
{
    public interface IOrganizationInvitationClient :
        INestedCreatable<OrganizationInvitationCreateRequest, SBOrganizationInvitation>,
        INestedRetrievable<SBOrganizationInvitation>,
        INestedDeletable<SBOrganizationInvitation>,
        INestedListable<OrganizationInvitationListRequest, SBOrganizationInvitation>
    {
        // Task<SBOrganizationInvitation> AcceptInvitationAsync(long organizationId, long invitationId, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }

    public class OrganizationInvitationClient : Service<SBOrganizationInvitation>, IOrganizationInvitationClient
    {
        public OrganizationInvitationClient(ISmartbillsClient client) : base(client) { }

        public async Task<SBOrganizationInvitation> CreateAsync(long organizationId, OrganizationInvitationCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/organizations/{organizationId}/invitations", request, options, cancellationToken);
        }

        public async Task<SBOrganizationInvitation> GetByIdAsync(long organizationId, long invitationId, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/organizations/{organizationId}/invitations/{invitationId}", options, cancellationToken);
        }

        public async Task<SBOrganizationInvitation> DeleteAsync(long organizationId, long invitationId, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/organizations/{organizationId}/invitations/{invitationId}", options, cancellationToken);
        }

        public async Task<SBList<SBOrganizationInvitation>> ListAsync(long organizationId, OrganizationInvitationListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/organizations/{organizationId}/invitations", request, options, cancellationToken);
        }

        // public async Task<SBOrganizationInvitation> AcceptInvitationAsync(long organizationId, long invitationId, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        // {
        //     return await UpdateEntityAsync($"/v1/organizations/{organizationId}/invitations/{invitationId}/accept", null, options, cancellationToken);
        // }
    }
}
