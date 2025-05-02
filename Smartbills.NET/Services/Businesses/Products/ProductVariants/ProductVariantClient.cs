using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Products.Variants;
using Smartbills.NET.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Merchants.Products.ProductVariants
{
    public interface IProductVariantClient
    {
        Task<SBProductVariant> CreateAsync(long businessId, long productId, ProductVariantCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBProductVariant> DeleteAsync(long businessId, long productId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBProductVariant> GetByIdAsync(long businessId, long productId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBProductVariant> UpdateAsync(long businessId, long productId, long id, ProductVariantUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<List<SBProductVariant>> BatchCreateAsync(long businessId, long productId, List<ProductVariantCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<List<SBProductVariant>> BatchUpdateAsync(long businessId, long productId, List<ProductVariantBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }

    public class ProductVariantClient : Service<SBProductVariant>, IProductVariantClient
    {
        public ProductVariantClient(ISmartbillsClient client) : base(client)
        {
        }

        public async Task<SBProductVariant> CreateAsync(long businessId, long productId, ProductVariantCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/businesses/{businessId}/products/{productId}/variants", request, options, cancellationToken);
        }

        public async Task<SBProductVariant> DeleteAsync(long businessId, long productId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/businesses/{businessId}/products/{productId}/variants/{id}", options, cancellationToken);
        }

        public async Task<SBProductVariant> GetByIdAsync(long businessId, long productId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/businesses/{businessId}/products/{productId}/variants/{id}", options, cancellationToken);
        }

        public async Task<SBProductVariant> UpdateAsync(long businessId, long productId, long id, ProductVariantUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/businesses/{businessId}/products/{productId}/variants/{id}", request, options, cancellationToken);
        }

        public async Task<List<SBProductVariant>> BatchCreateAsync(long businessId, long productId, List<ProductVariantCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<List<ProductVariantCreateRequest>, List<SBProductVariant>>($"/v1/businesses/{businessId}/products/{productId}/variants/batch", request, options, cancellationToken);
        }

        public async Task<List<SBProductVariant>> BatchUpdateAsync(long businessId, long productId, List<ProductVariantBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<List<ProductVariantBatchItemUpdateRequest>, List<SBProductVariant>>($"/v1/businesses/{businessId}/products/{productId}/variants/batch", request, options, cancellationToken);
        }
    }
}
