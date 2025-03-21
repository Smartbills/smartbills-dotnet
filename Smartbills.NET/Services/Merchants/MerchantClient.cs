using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Merchants;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Merchants
{
    public interface IMerchantClient :
        IRetrievableById<SBMerchant>,
        ICreatable<MerchantCreateRequest, SBMerchant>,
        IUpdatable<MerchantUpdateRequest, SBMerchant>,
        IDeletable<SBMerchant>,
        IListable<ListMerchantRequest, SBMerchant>
    { }

    public class MerchantClient : Service<SBMerchant>, IMerchantClient
    {
        public MerchantClient(ISmartbillsClient smartbills) : base(smartbills)
        {
        }

        public async Task<SBMerchant> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/merchants/{id}", options, cancellationToken);
        }

        public async Task<SBMerchant> CreateAsync(MerchantCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/merchants", request, options, cancellationToken);
        }

        public async Task<SBMerchant> UpdateAsync(long id, MerchantUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/merchants/{id}", request, options, cancellationToken);
        }

        public async Task<SBMerchant> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/merchants/{id}", options, cancellationToken);
        }

        public async Task<SBList<SBMerchant>> ListAsync(ListMerchantRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync("/v1/merchants", request, options, cancellationToken);
        }
    }
}
