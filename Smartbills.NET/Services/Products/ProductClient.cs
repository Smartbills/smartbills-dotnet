using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Products;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Products
{
    public interface IProductClient : ICreatable<SBProduct, CreateProductRequest>,
        IUpdatable<SBProduct, UpdateProductRequest>,
        IDeletable<SBProduct, DeleteProductRequest>,
        IRetrievable<SBProduct>
    { }

    public class ProductClient : ClientBase<SBProduct>, IProductClient
    {
        public ProductClient(ISmartbillsClient client) : base(client)
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

        public async Task<SBProduct> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync(id, cancellationToken);
        }

        public async Task<SBProduct> UpdateAsync(long id, UpdateProductRequest request, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, request, cancellationToken);
        }
    }
}
