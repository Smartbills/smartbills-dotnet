using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Discounts;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Discounts
{

    public interface IDiscountClient :  ICreatable<CreateDiscountRequest, SBDiscount>, IUpdatable<UpdateDiscountRequest, SBDiscount>, IDeletable<SBDiscount>, IRetrievable<SBDiscount>
    {

    }
    public class DiscountClient : Service<SBDiscount>, IDiscountClient
    {
        public DiscountClient(ISmartbillsClient smartbills) : base(smartbills)
        {
        }

        public async Task<SBDiscount> CreateAsync(CreateDiscountRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
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

        public async Task<SBDiscount> UpdateAsync(long id, UpdateDiscountRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/discounts/{id}", request, options, cancellationToken);
        }
    }
}
