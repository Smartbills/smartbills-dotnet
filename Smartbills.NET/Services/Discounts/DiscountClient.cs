using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Discounts;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Discounts
{

    public interface IDiscountClient :  ICreatable<DiscountCreateRequest, SBDiscount>, IUpdatable<DiscountUpdateRequest, SBDiscount>, IDeletable<SBDiscount>, IRetrievable<SBDiscount>
    {

    }
    public class DiscountClient : Service<SBDiscount>, IDiscountClient
    {
        public DiscountClient(ISmartbillsClient smartbills) : base(smartbills)
        {
        }

        public async Task<SBDiscount> CreateAsync(DiscountCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/discounts", request, options, cancellationToken);
        }

        public async Task<SBDiscount> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/discounts/{id}", options, cancellationToken);
        }

        public async Task<SBDiscount> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/discounts/{id}", options, cancellationToken);
        }

        public async Task<SBDiscount> UpdateAsync(long id, DiscountUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/discounts/{id}", request, options, cancellationToken);
        }
    }
}
