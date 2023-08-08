using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Merchants;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Merchants
{
    public interface IMerchantClient :
    IRetrievable<SBMerchant>,
    ICreatable<CreateMerchantRequest, SBMerchant>,
    IUpdatable<UpdateMerchantRequest, SBMerchant>,
    IDeletable<SBMerchant>
    {
    }
    public class MerchantClient :
    Service<SBMerchant>,
        IMerchantClient

    {
        public MerchantClient(ISmartbillsClient smartbills) : base(smartbills)
        {
        }

        public async Task<SBMerchant> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/merchants/{id}", options, cancellationToken);
        }

        public async Task<SBMerchant> CreateAsync(CreateMerchantRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/merchants", request, options, cancellationToken);
        }

        public async Task<SBMerchant> UpdateAsync(long id, UpdateMerchantRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/merchants/{id}", request, options, cancellationToken);
        }

        public async Task<SBMerchant> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/merchants/{id}", options, cancellationToken);
        }
    }
}
