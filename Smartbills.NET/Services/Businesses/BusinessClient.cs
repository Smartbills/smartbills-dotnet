using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Businesses;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Businesses
{
    public interface IBusinessClient :
        IRetrievableById<SBBusiness>,
        ICreatable<BusinessCreateRequest, SBBusiness>,
        IUpdatable<BusinessUpdateRequest, SBBusiness>,
        IDeletable<SBBusiness>,
        IListable<BusinessListRequest, SBBusiness>
    { }

    public class BusinessClient : Service<SBBusiness>, IBusinessClient
    {
        public BusinessClient(ISmartbillsClient smartbills) : base(smartbills)
        {
        }

        public async Task<SBBusiness> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/businesses/{id}", options, cancellationToken);
        }

        public async Task<SBBusiness> CreateAsync(BusinessCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/businesses", request, options, cancellationToken);
        }

        public async Task<SBBusiness> UpdateAsync(long id, BusinessUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/businesses/{id}", request, options, cancellationToken);
        }

        public async Task<SBBusiness> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/businesses/{id}", options, cancellationToken);
        }

        public async Task<SBList<SBBusiness>> ListAsync(BusinessListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync("/v1/businesses", request, options, cancellationToken);
        }
    }
}