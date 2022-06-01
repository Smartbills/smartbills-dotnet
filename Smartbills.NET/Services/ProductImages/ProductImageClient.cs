using RestSharp;
using Smarbtills.NET.Services;
using Smartbills.Client.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{

    public interface IProductImageClient : ICreatable<SBProductImage, CreateProductImageRequest>,
        IRetrievable<SBProductImage, GetProductImageRequest>,
        IUpdatable<SBProductImage, UpdateProductImageRequest>,
        IDeletable<SBProductImage, DeleteProductImageRequest>
    {

    }
    public class ProductImageClient :
    Service<SBProductImage>, IProductImageClient

    {
        public override string BasePath => "product/{PARENT_ID}/images";

        public ProductImageClient(SmartbillsClient client) : base(client) { }


        public async Task<SBProductImage> CreateAsync(CreateProductImageRequest options, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(options, cancellationToken);
        }
        public async Task<SBProductImage> GetAsync(long id, GetProductImageRequest options = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityAsync(id, options, cancellationToken);
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
