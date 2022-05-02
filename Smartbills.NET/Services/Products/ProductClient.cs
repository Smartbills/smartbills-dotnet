using Smartbills.Client;
using Smartbills.Client.Entities;
using Smartbills.Client.Entities.Products;
using Smartbills.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services.Products
{
    public interface IProductClient : ICreateable<SBProduct, CreateProductRequest>,
        IUpdateable<SBProduct, UpdateProductRequest>,
        IDeleteable<SBProduct, DeleteProductRequest>,
        IRetrievable<SBProduct, GetProductRequest>
    { }

    public class ProductClient : Service<SBProduct>, IProductClient
    {
        public ProductClient(ISmartbillsClient client) : base(client)
        {
        }

        public override string BasePath => "products";

        public async Task<SmartbillsResponse<SBProduct>> CreateAsync(CreateProductRequest request, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(request, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBProduct>> DeleteAsync(long id, DeleteProductRequest request, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync(id, request, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBProduct>> GetAsync(long id, GetProductRequest request, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityAsync(id,request, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBProduct>> UpdateAsync(long id, UpdateProductRequest request, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, request, requestOptions, cancellationToken);
        }
    }
}
