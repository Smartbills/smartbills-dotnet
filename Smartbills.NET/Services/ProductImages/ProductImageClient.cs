using Smartbills.NET.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services
{

    public interface IProductImageClient : ICreatable<SBProductImage, CreateProductImageRequest>,
        IRetrievable<SBProductImage>,
        IUpdatable<SBProductImage, UpdateProductImageRequest>,
        IDeletable<SBProductImage, DeleteProductImageRequest>
    {

    }
    public class ProductImageClient :
    ClientBase<SBProductImage>, IProductImageClient

    {
        public override string BasePath => "product/{PARENT_ID}/images";

        public ProductImageClient(ISmartbillsClient client) : base(client) { }


        public async Task<SBProductImage> CreateAsync(CreateProductImageRequest options, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(options, cancellationToken);
        }
        public async Task<SBProductImage> GetByIdAsync(long id,  CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync(id,  cancellationToken);
        }
        public async Task<SBProductImage> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync(id, cancellationToken);
        }

        public async Task<SBProductImage> UpdateAsync(long id, UpdateProductImageRequest options, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, options, cancellationToken);
        }
    }
}
