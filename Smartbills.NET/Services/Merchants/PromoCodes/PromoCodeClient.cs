using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.PromoCodes;
using Smartbills.NET.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.PromoCodes
{
    public interface IPromoCodeClient :
        ICreatable<PromoCodeCreateRequest, SBPromoCode>,
        IUpdatable<PromoCodeUpdateRequest, SBPromoCode>,
        IDeletable<SBPromoCode>,
        IRetrievableById<SBPromoCode>,
        IBatchCreate<PromoCodeCreateRequest, SBPromoCode>,
        IBatchUpdate<PromoCodeBatchItemUpdateRequest, SBPromoCode>
    {

    }
    public class PromoCodeClient : Service<SBPromoCode>, IPromoCodeClient
    {
        public PromoCodeClient(ISmartbillsClient smartbills) : base(smartbills)
        {
        }

        public async Task<SBPromoCode> CreateAsync(PromoCodeCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/promo-codes", request, options, cancellationToken);
        }

        public async Task<SBPromoCode> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/promo-codes/{id}", options, cancellationToken);
        }

        public async Task<SBPromoCode> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/promo-codes/{id}", options, cancellationToken);
        }

        public async Task<SBPromoCode> UpdateAsync(long id, PromoCodeUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/promo-codes/{id}", request, options, cancellationToken);
        }

        public async Task<List<SBPromoCode>> BatchCreateAsync(List<PromoCodeCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync<List<PromoCodeCreateRequest>, List<SBPromoCode>>("/v1/promo-codes/batch", request, options, cancellationToken);
        }

        public async Task<List<SBPromoCode>> BatchUpdateAsync(List<PromoCodeBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync<List<PromoCodeBatchItemUpdateRequest>, List<SBPromoCode>>("/v1/promo-codes/batch", request, options, cancellationToken);
        }
    }
}
