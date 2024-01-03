using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.ProductImages;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.ProductImages
{

    public interface IProductImageClient : 
        INestedCreatable<ProductImageCreateRequest, SBProductImage>,
        INestedRetrievable<SBProductImage>,
        INestedUpdatable<ProductImageUpdateRequest, SBProductImage>,
        INestedDeletable<SBProductImage>
    {

    }
    public class ProductImageClient :
    Service<SBProductImage>, IProductImageClient

    {
        public ProductImageClient(ISmartbillsClient smartbills) : base(smartbills)
        {
        }


        public async Task<SBProductImage> CreateAsync(long id, ProductImageCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/products/{id}/images", request, options, cancellationToken);
        }
        public async Task<SBProductImage> GetByIdAsync(long id, long imageId, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {

            return await GetEntityByIdAsync($"/v1/products/{id}/images/{imageId}", options, cancellationToken);
        }
        public async Task<SBProductImage> DeleteAsync(long id, long imageId, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/products/{id}/images/{imageId}", options, cancellationToken);
        }

        public async Task<SBProductImage> UpdateAsync(long id, long imageId, ProductImageUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/products/{id}/images/{imageId}", request, options, cancellationToken);
        }

    }
}
