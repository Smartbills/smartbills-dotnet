using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Products.Options;
using Smartbills.NET.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Merchants.Products.ProductOptions
{
    public interface IProductOptionClient
    {
        Task<SBProductOption> CreateAsync(long merchantId, long productId, ProductOptionCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBProductOption> GetByIdAsync(long merchantId, long productId, long optionId, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBProductOption> DeleteAsync(long merchantId, long productId, long optionId, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBProductOption> UpdateAsync(long merchantId, long productId, long optionId, ProductOptionUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<List<SBProductOption>> BatchCreateAsync(long merchantId, long productId, List<ProductOptionCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<List<SBProductOption>> BatchUpdateAsync(long merchantId, long productId, List<ProductOptionBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }

    public class ProductOptionClient : Service<SBProductOption>, IProductOptionClient
    {
        public ProductOptionClient(ISmartbillsClient client) : base(client)
        {
        }

        public async Task<SBProductOption> CreateAsync(long merchantId, long productId, ProductOptionCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/merchants/{merchantId}/products/{productId}/options", request, options, cancellationToken);
        }

        public async Task<SBProductOption> GetByIdAsync(long merchantId, long productId, long optionId, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/merchants/{merchantId}/products/{productId}/options/{optionId}", options, cancellationToken);
        }

        public async Task<SBProductOption> DeleteAsync(long merchantId, long productId, long optionId, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/merchants/{merchantId}/products/{productId}/options/{optionId}", options, cancellationToken);
        }

        public async Task<SBProductOption> UpdateAsync(long merchantId, long productId, long optionId, ProductOptionUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/merchants/{merchantId}/products/{productId}/options/{optionId}", request, options, cancellationToken);
        }

        public async Task<List<SBProductOption>> BatchCreateAsync(long merchantId, long productId, List<ProductOptionCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<List<ProductOptionCreateRequest>, List<SBProductOption>>($"/v1/merchants/{merchantId}/products/{productId}/options/batch", request, options, cancellationToken);
        }

        public async Task<List<SBProductOption>> BatchUpdateAsync(long merchantId, long productId, List<ProductOptionBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<List<ProductOptionBatchItemUpdateRequest>, List<SBProductOption>>($"/v1/merchants/{merchantId}/products/{productId}/options/batch", request, options, cancellationToken);
        }
    }
}
