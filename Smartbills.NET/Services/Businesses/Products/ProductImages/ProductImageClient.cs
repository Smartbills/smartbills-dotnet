using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Products.Images;
using Smartbills.NET.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Merchants.Products.ProductImages
{
    public interface IProductImageClient
    {
        Task<SBProductImage> CreateAsync(long businessId, long productId, ProductImageCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBProductImage> GetByIdAsync(long businessId, long productId, long imageId, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBProductImage> DeleteAsync(long businessId, long productId, long imageId, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBProductImage> UpdateAsync(long businessId, long productId, long imageId, ProductImageUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<List<SBProductImage>> BatchCreateAsync(long businessId, long productId, List<ProductImageCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<List<SBProductImage>> BatchUpdateAsync(long businessId, long productId, List<ProductImageBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }

    public class ProductImageClient : Service<SBProductImage>, IProductImageClient
    {
        public ProductImageClient(ISmartbillsClient smartbills) : base(smartbills)
        {
        }

        public async Task<SBProductImage> CreateAsync(long businessId, long productId, ProductImageCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/businesses/{businessId}/products/{productId}/images", request, options, cancellationToken);
        }

        public async Task<SBProductImage> GetByIdAsync(long businessId, long productId, long imageId, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/businesses/{businessId}/products/{productId}/images/{imageId}", options, cancellationToken);
        }

        public async Task<SBProductImage> DeleteAsync(long businessId, long productId, long imageId, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/businesses/{businessId}/products/{productId}/images/{imageId}", options, cancellationToken);
        }

        public async Task<SBProductImage> UpdateAsync(long businessId, long productId, long imageId, ProductImageUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/businesses/{businessId}/products/{productId}/images/{imageId}", request, options, cancellationToken);
        }

        public async Task<List<SBProductImage>> BatchCreateAsync(long businessId, long productId, List<ProductImageCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<List<ProductImageCreateRequest>, List<SBProductImage>>($"/v1/businesses/{businessId}/products/{productId}/images/batch", request, options, cancellationToken);
        }

        public async Task<List<SBProductImage>> BatchUpdateAsync(long businessId, long productId, List<ProductImageBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<List<ProductImageBatchItemUpdateRequest>, List<SBProductImage>>($"/v1/businesses/{businessId}/products/{productId}/images/batch", request, options, cancellationToken);
        }
    }
}
