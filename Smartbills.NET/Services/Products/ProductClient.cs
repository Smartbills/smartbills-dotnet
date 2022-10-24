using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Products;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Products
{
    public interface IProductClient : ICreatable<CreateProductRequest, SBProduct>,
        IUpdatable<UpdateProductRequest,SBProduct>,
        IDeletable<SBProduct>,
        IRetrievable<SBProduct>
    { }

    public class ProductClient : ClientBase<SBProduct>, IProductClient
    {
        public ProductClient(ISmartbillsClient client) : base(client)
        {
        }

        public ProductClient(SBClientCredentials credentials) : base(credentials)
        {
        }

        public ProductClient(string accessToken, string url = "https://api.smartbills.io") : base(accessToken, url)
        {
        }

        public ProductClient(string apiKey, string apiSecret, string url = "https://api.smartbills.io") : base(apiKey, apiSecret, url)
        {
        }


        public async Task<SBProduct> CreateAsync( CreateProductRequest request, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync("/v1/products", request, cancellationToken);
        }

        public async Task<SBProduct> DeleteAsync( long id, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync($"/v1/products/{id}", cancellationToken);
        }

        public async Task<SBProduct> GetByIdAsync( long id, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync($"/v1/products/{id}", cancellationToken);
        }

        public async Task<SBProduct> GetAsync(long id, GetProductRequest request, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityAsync($"/v1/products/{id}", request, cancellationToken);
        }


        public async Task<SBProduct> UpdateAsync( long id, UpdateProductRequest request, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync($"/v1/products/{id}", request, cancellationToken);
        }
    }
}
