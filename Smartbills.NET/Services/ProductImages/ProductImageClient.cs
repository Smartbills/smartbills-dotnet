using Smartbills.NET.Entities.ProductImages;
using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services._base;
using Smartbills.NET.Services._interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.ProductImages
{

    public interface IProductImageClient : ICreatable<SBProductImage, CreateProductImageRequest>,
        IRetrievable<SBProductImage>,
        IUpdatable<SBProductImage, UpdateProductImageRequest>,
        IDeletable<SBProductImage>
    {

    }
    public class ProductImageClient :
    ClientBase<SBProductImage>, IProductImageClient

    {
        public override string BasePath => "product/{PARENT_ID}/images";

        public ProductImageClient(ISmartbillsClient client) : base(client) { }


        public async Task<SBProductImage> CreateAsync(CreateProductImageRequest options, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync(options, cancellationToken);
        }
        public async Task<SBProductImage> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync(id, cancellationToken);
        }
        public async Task<SBProductImage> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync(id, cancellationToken);
        }

        public async Task<SBProductImage> UpdateAsync(long id, UpdateProductImageRequest options, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync(id, options, cancellationToken);
        }
    }
}
