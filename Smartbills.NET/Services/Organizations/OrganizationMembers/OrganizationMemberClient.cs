using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Organizations.Members;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Organizations.OrganizationMembers
{
    public interface IOrganizationMemberClient :
        INestedCreatable<OrganizationMemberCreateRequest, SBOrganizationMember>,
        INestedRetrievable<SBOrganizationMember>,
        INestedDeletable<SBOrganizationMember>,
        INestedListable<OrganizationMemberListRequest, SBList<SBOrganizationMember>>
    {
        Task<SBOrganizationMember> UpdateRoleAsync(long organizationId, long memberId, OrganizationMemberRoleUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }

    public class OrganizationMemberClient : Service<SBOrganizationMember>, IOrganizationMemberClient
    {
        public OrganizationMemberClient(ISmartbillsClient client) : base(client) { }

        public async Task<SBOrganizationMember> CreateAsync(long organizatioId, OrganizationMemberCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/organizations/{organizatioId}/members", request, options, cancellationToken);
        }

        public async Task<SBOrganizationMember> GetByIdAsync(long organizatioId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/organizations/{organizatioId}/members/{id}", options, cancellationToken);
        }

        public async Task<SBOrganizationMember> DeleteAsync(long organizatioId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/organizations/{organizatioId}/members/{id}", options, cancellationToken);
        }

        public async Task<SBList<SBOrganizationMember>> ListAsync(long organizatioId, OrganizationMemberListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/organizations/{organizatioId}", request, options, cancellationToken);
        }

        public async Task<SBOrganizationMember> UpdateRoleAsync(long organizatioId, long id, OrganizationMemberRoleUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/organizations/{organizatioId}/members/{id}", request, options, cancellationToken);
        }
    }
}
