using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Discount;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Discounts
{

    public interface IDiscountClient: IMerchantClientBase, ICreatable<CreateDiscountRequest, SBDiscount>, IUpdatable<UpdateDiscountRequest, SBDiscount>, IDeletable<SBDiscount>, IRetrievable<SBDiscount>
    {

    }
    public class DiscountClient : MerchantClientBase<SBDiscount>, IDiscountClient
    {
        public DiscountClient(ISmartbillsClient smartbills) : base(smartbills)
        {
        }

        public DiscountClient(long merchantId, SBClientCredentials credentials, string url = "https://api.smartbills.io") : base(merchantId, credentials, url)
        {
        }

        public DiscountClient(long merchantId, string accessToken, string url = "https://api.smartbills.io") : base(merchantId, accessToken, url)
        {
        }

        public DiscountClient(long merchantId, string apiKey, string apiSecret, string url = "https://api.smartbills.io") : base(merchantId, apiKey, apiSecret, url)
        {
        }

        public async Task<SBDiscount> CreateAsync(CreateDiscountRequest request, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/discounts",request, cancellationToken);
        }

        public async Task<SBDiscount> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/discounts/{id}", cancellationToken);
        }

        public async Task<SBDiscount> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/discounts/{id}", cancellationToken);
        }

        public async Task<SBDiscount> UpdateAsync(long id, UpdateDiscountRequest request, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/discounts/{id}", request, cancellationToken);
        }
    }
}
