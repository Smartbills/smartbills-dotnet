using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.ProductVariants;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.ProductVariants
{
    public interface IProductVariantClient : 
        INestedCreatable<CreateProductVariantRequest, SBProductVariant>,
        INestedUpdatable<UpdateProductVariantRequest, SBProductVariant>,
        INestedDeletable<SBProductVariant>,
        INestedRetrievable<SBProductVariant>
    { }

    public class ProductVariantClient : Service<SBProductVariant>, IProductVariantClient
    {
        public ProductVariantClient(ISmartbillsClient client) : base(client)
        {
        }

        public async Task<SBProductVariant> CreateAsync(long parentId, CreateProductVariantRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync($"/v1/products/{parentId}/variants", request, options, cancellationToken);
        }

        public async Task<SBProductVariant> DeleteAsync(long parentId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync($"/v1/products/{parentId}/variants/{id}", options, cancellationToken);
        }

        public async Task<SBProductVariant> GetByIdAsync(long parentId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync($"/v1/products/{parentId}/variants/{id}", options, cancellationToken);
        }

        public async Task<SBProductVariant> UpdateAsync(long parentId, long id, UpdateProductVariantRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync($"/v1/products/{parentId}/variants/{id}", request, options, cancellationToken);
        }
    }
}
