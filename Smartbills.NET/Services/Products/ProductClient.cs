using RestSharp;
using Smarbtills.NET.Services;
using Smartbills.Client.Entities;
using Smartbills.Client.Entities.Products;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services.Products
{
    public interface IProductClient : ICreatable<SBProduct, CreateProductRequest>,
        IUpdatable<SBProduct, UpdateProductRequest>,
        IDeletable<SBProduct, DeleteProductRequest>,
        IRetrievable<SBProduct, GetProductRequest>
    { }

    public class ProductClient : Service<SBProduct>, IProductClient
    {
        public ProductClient(SmartbillsClient client) : base(client)
        {
        }

        public override string BasePath => "products";

        public async Task<SBProduct> CreateAsync(CreateProductRequest request, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(request, cancellationToken);
        }

        public async Task<SBProduct> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync(id, cancellationToken);
        }

        public async Task<SBProduct> GetAsync(long id, GetProductRequest request = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync(id, request, cancellationToken);
        }

        public async Task<SBProduct> UpdateAsync(long id, UpdateProductRequest request, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, request, cancellationToken);
        }
    }
}
