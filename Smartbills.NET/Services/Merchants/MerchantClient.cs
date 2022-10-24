using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Merchants;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Merchants
{
    public interface IMerchantClient :
    IRetrievable<SBMerchant>,
    ICreatable<CreateMerchantRequest,SBMerchant>,
    IUpdatable<UpdateMerchantRequest, SBMerchant>,
    IDeletable<SBMerchant>
    {
    }
    public class MerchantClient :
    ClientBase<SBMerchant>,
        IMerchantClient

    {
        public MerchantClient(ISmartbillsClient smartbills) : base(smartbills)
        {
        }

        public MerchantClient(SBClientCredentials credentials) : base(credentials)
        {
        }

        public MerchantClient(string accessToken, string url = "https://api.smartbills.io") : base(accessToken, url)
        {
        }

        public MerchantClient(string apiKey, string apiSecret, string url = "https://api.smartbills.io") : base(apiKey, apiSecret, url)
        {
        }

        public async Task<SBMerchant> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/merchants/{id}", cancellationToken);
        }

        public async Task<SBMerchant> CreateAsync(CreateMerchantRequest request, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/merchants",request, cancellationToken);
        }

        public async Task<SBMerchant> UpdateAsync(long id, UpdateMerchantRequest request, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/merchants/${id}", request, cancellationToken);
        }

        public async Task<SBMerchant> DeleteAsync(long id,  CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/merchants/${id}", cancellationToken);
        }
    }
}
