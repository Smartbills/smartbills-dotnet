using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Organizations;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Organizations
{
    public interface IOrganizationClient :
        ICreatable<OrganizationCreateRequest, SBOrganization>,
        IRetrievableById<SBOrganization>,
        IUpdatable<OrganizationUpdateRequest, SBOrganization>,
        IDeletable<SBOrganization>,
        IListable<OrganizationListRequest, SBOrganization>
    {
    }

    public class OrganizationClient : Service<SBOrganization>, IOrganizationClient
    {
        public OrganizationClient(ISmartbillsClient client) : base(client) { }

        public async Task<SBOrganization> CreateAsync(OrganizationCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/organizations", request, options, cancellationToken);
        }

        public async Task<SBOrganization> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/organizations/{id}", options, cancellationToken);
        }

        public async Task<SBOrganization> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/organizations/{id}", options, cancellationToken);
        }

        public async Task<SBList<SBOrganization>> ListAsync(OrganizationListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/organizations", request, options, cancellationToken);
        }

        public async Task<SBOrganization> UpdateAsync(long id, OrganizationUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/organizations/{id}", request, options, cancellationToken);
        }


    }
}