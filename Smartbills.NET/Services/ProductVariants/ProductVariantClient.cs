using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.ProductVariants;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.ProductVariants
{
    public interface IProductVariantClient : IMerchantClientBase,
        INestedCreatable<CreateProductVariantRequest, SBProductVariant>,
        INestedUpdatable<UpdateProductVariantRequest, SBProductVariant>,
        INestedDeletable<SBProductVariant>,
        INestedRetrievable<SBProductVariant>
    { }

    public class ProductVariantClient : MerchantClientBase<SBProductVariant>, IProductVariantClient
    {
        public ProductVariantClient(ISmartbillsClient client) : base(client)
        {
        }

        public ProductVariantClient(long merchantId, string accessToken, string url = "https://api.smartbills.io") : base(merchantId, accessToken, url)
        {
        }

        public ProductVariantClient(long merchantId, string apiKey, string apiSecret, string url = "https://api.smartbills.io") : base(merchantId, apiKey, apiSecret, url)
        {
        }

        public ProductVariantClient(long merchantId, SBClientCredentials credentials, string url = "https://api.smartbills.io") : base(merchantId, credentials, url)
        {
        }

        public async Task<SmartbillsResponse<SBProductVariant>> CreateAsync(long parentId, CreateProductVariantRequest request, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync($"/v1/products/{parentId}/variants", request, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBProductVariant>> DeleteAsync(long parentId, long id, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync($"/v1/products/{parentId}/variants/{id}", cancellationToken);
        }

        public async Task<SmartbillsResponse<SBProductVariant>> GetByIdAsync(long parentId, long id, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync($"/v1/products/{parentId}/variants/{id}", cancellationToken);
        }

        public async Task<SmartbillsResponse<SBProductVariant>> UpdateAsync(long parentId, long id, UpdateProductVariantRequest request, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync($"/v1/products/{parentId}/variants/{id}", request, cancellationToken);
        }
    }
}
