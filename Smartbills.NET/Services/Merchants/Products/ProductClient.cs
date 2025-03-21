using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Products;
using Smartbills.NET.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Merchants.Products
{
    public interface IProductClient :
        INestedCreatable<ProductCreateRequest, SBProduct>,
        INestedUpdatable<ProductUpdateRequest, SBProduct>,
        INestedDeletable<SBProduct>,
        INestedRetrievable<SBProduct>,
        INestedListable<ProductListRequest, SBProduct>,
        INestedBatchCreate<ProductCreateRequest, SBProduct>,
        INestedBatchUpdate<ProductBatchItemUpdateRequest, SBProduct>
    { }

    public class ProductClient : Service<SBProduct>, IProductClient
    {
        public ProductClient(ISmartbillsClient client) : base(client)
        {
        }

        public async Task<SBProduct> CreateAsync(long merchantId, ProductCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/merchants/{merchantId}/products", request, options, cancellationToken);
        }

        public async Task<SBProduct> DeleteAsync(long merchantId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/merchants/{merchantId}/products/{id}", options, cancellationToken);
        }

        public async Task<SBProduct> GetByIdAsync(long merchantId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/merchants/{merchantId}/products/{id}", options, cancellationToken);
        }

        public async Task<SBList<SBProduct>> ListAsync(long merchantId, ProductListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/merchants/{merchantId}/products", request, options, cancellationToken);
        }

        public async Task<SBProduct> UpdateAsync(long merchantId, long id, ProductUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/merchants/{merchantId}/products/{id}", request, options, cancellationToken);
        }

        public async Task<List<SBProduct>> BatchCreateAsync(long merchantId, List<ProductCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<List<ProductCreateRequest>, List<SBProduct>>($"/v1/merchants/{merchantId}/products/batch", request, options, cancellationToken);
        }

        public async Task<List<SBProduct>> BatchUpdateAsync(long merchantId, List<ProductBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<List<ProductBatchItemUpdateRequest>, List<SBProduct>>($"/v1/merchants/{merchantId}/products/batch", request, options, cancellationToken);
        }
    }
}
