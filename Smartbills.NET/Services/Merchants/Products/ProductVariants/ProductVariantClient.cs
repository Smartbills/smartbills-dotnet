﻿using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Products.Variants;
using Smartbills.NET.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Merchants.Products.ProductVariants
{
    public interface IProductVariantClient :
        INestedCreatable<ProductVariantCreateRequest, SBProductVariant>,
        INestedUpdatable<ProductVariantUpdateRequest, SBProductVariant>,
        INestedDeletable<SBProductVariant>,
        INestedRetrievable<SBProductVariant>,
        INestedBatchCreate<ProductVariantCreateRequest, SBProductVariant>,
        INestedBatchUpdate<ProductVariantBatchItemUpdateRequest, SBProductVariant>
    { }

    public class ProductVariantClient : Service<SBProductVariant>, IProductVariantClient
    {
        public ProductVariantClient(ISmartbillsClient client) : base(client)
        {
        }

        public async Task<SBProductVariant> CreateAsync(long parentId, ProductVariantCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/products/{parentId}/variants", request, options, cancellationToken);
        }

        public async Task<SBProductVariant> DeleteAsync(long parentId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/products/{parentId}/variants/{id}", options, cancellationToken);
        }

        public async Task<SBProductVariant> GetByIdAsync(long parentId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/products/{parentId}/variants/{id}", options, cancellationToken);
        }

        public async Task<SBProductVariant> UpdateAsync(long parentId, long id, ProductVariantUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/products/{parentId}/variants/{id}", request, options, cancellationToken);
        }


        public async Task<List<SBProductVariant>> BatchCreateAsync(long parentId, List<ProductVariantCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<List<ProductVariantCreateRequest>, List<SBProductVariant>>($"/v1/products/{parentId}/variants/batch", request, options, cancellationToken);
        }

        public async Task<List<SBProductVariant>> BatchUpdateAsync(long parentId, List<ProductVariantBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<List<ProductVariantBatchItemUpdateRequest>, List<SBProductVariant>>($"/v1/products/{parentId}/variants/batch", request, options, cancellationToken);
        }

    }
}
