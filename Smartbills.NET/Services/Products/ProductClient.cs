using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Products;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Products
{
    public interface IProductClient :  ICreatable<CreateProductRequest, SBProduct>,
        IUpdatable<UpdateProductRequest, SBProduct>,
        IDeletable<SBProduct>,
        IRetrievable<SBProduct>,
        IPageable<GetProductRequest, PaginatedResponse<SBProduct>>

    { }

    public class ProductClient : Service<SBProduct>, IProductClient
    {
        public ProductClient(ISmartbillsClient client) : base(client)
        {
        }

        public async Task<SBProduct> CreateAsync(CreateProductRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync("/v1/products", request, options, cancellationToken);
        }

        public async Task<SBProduct> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync($"/v1/products/{id}", options, cancellationToken);
        }

        public async Task<SBProduct> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync($"/v1/products/{id}", options, cancellationToken);
        }

        public async Task<PaginatedResponse<SBProduct>> PaginateAsync(long id, GetProductRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.PaginateEntityAsync($"/v1/products/{id}", request, options, cancellationToken);
        }

        public async Task<SBProduct> UpdateAsync(long id, UpdateProductRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync($"/v1/products/{id}", request, options, cancellationToken);
        }
    }
}
