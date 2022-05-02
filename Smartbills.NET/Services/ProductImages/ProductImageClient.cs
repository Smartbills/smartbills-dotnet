using Smartbills.Client.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{

    public interface IProductImageClient : ICreateable<SBProductImage, CreateProductImageRequest>,
    IRetrievable<SBProductImage, GetProductImageRequest>,
        IUpdateable<SBProductImage, UpdateProductImageRequest>,
        IDeleteable<SBProductImage, DeleteProductImageRequest>
    {

    }
    public class ProductImageClient :
    Service<SBProductImage>, IProductImageClient

    {
        public override string BasePath => "product/{PARENT_ID}/images";

        public ProductImageClient(ISmartbillsClient client) : base(client) { }


        public async Task<SmartbillsResponse<SBProductImage>> CreateAsync(CreateProductImageRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(options, requestOptions, cancellationToken);
        }
        public async Task<SmartbillsResponse<SBProductImage>> GetAsync(long id, GetProductImageRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }
        public async Task<SmartbillsResponse<SBProductImage>> DeleteAsync(long id, DeleteProductImageRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBProductImage>> UpdateAsync(long id, UpdateProductImageRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
