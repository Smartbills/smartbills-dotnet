using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.ProductImages;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.ProductImages
{

    public interface IProductImageClient : INestedCreatable<CreateProductImageRequest,SBProductImage>,
        INestedRetrievable<SBProductImage>,
        INestedUpdatable<UpdateProductImageRequest, SBProductImage>,
        INestedDeletable<SBProductImage>
    {

    }
    public class ProductImageClient :
    ClientBase<SBProductImage>, IProductImageClient

    {

        public ProductImageClient(ISmartbillsClient client) : base(client) { }

        public ProductImageClient(SBClientCredentials credentials) : base(credentials)
        {
        }

        public ProductImageClient(string accessToken, string url = "https://api.smartbills.io") : base(accessToken, url)
        {
        }

        public ProductImageClient(string apiKey, string apiSecret, string url = "https://api.smartbills.io") : base(apiKey, apiSecret, url)
        {
        }

        public async Task<SBProductImage> CreateAsync(long id, CreateProductImageRequest request, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/products/{id}/images", request, cancellationToken);
        }
        public async Task<SBProductImage> GetByIdAsync(long id, long imageId, CancellationToken cancellationToken = default)
        {
      
            return await GetEntityByIdAsync($"/v1/products/{id}/images/{imageId}", cancellationToken);
        }
        public async Task<SBProductImage> DeleteAsync(long id, long imageId, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/products/{id}/images/{imageId}", cancellationToken);
        }

        public async Task<SBProductImage> UpdateAsync(long id,long imageId, UpdateProductImageRequest request, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/products/{id}/images/{imageId}", request, cancellationToken);
        }

    }
}
