using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Products;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Products
{
    public interface IProductClient : IMerchantClientBase, ICreatable<CreateProductRequest, SBProduct>,
        IUpdatable<UpdateProductRequest, SBProduct>,
        IDeletable<SBProduct>,
        IRetrievable<SBProduct>,
        IPageable<GetProductRequest, PaginatedResponse<SBProduct>>

    { }

    public class ProductClient : MerchantClientBase<SBProduct>, IProductClient
    {
        public ProductClient(ISmartbillsClient client) : base(client)
        {
        }

        public ProductClient(long merchantId, string accessToken, string url = "https://api.smartbills.io") : base(merchantId, accessToken, url)
        {
        }

        public ProductClient(long merchantId, string apiKey, string apiSecret, string url = "https://api.smartbills.io") : base(merchantId, apiKey, apiSecret, url)
        {
        }

        public ProductClient(long merchantId, SBClientCredentials credentials, string url = "https://api.smartbills.io") : base(merchantId, credentials, url)
        {
        }

        public async Task<SmartbillsResponse<SBProduct>> CreateAsync(CreateProductRequest request, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync("/v1/products", request, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBProduct>> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync($"/v1/products/{id}", cancellationToken);
        }

        public async Task<SmartbillsResponse<SBProduct>> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync($"/v1/products/{id}", cancellationToken);
        }

        public async Task<SmartbillsResponse<PaginatedResponse<SBProduct>>> PaginateAsync(long id, GetProductRequest request, CancellationToken cancellationToken = default)
        {
            return await base.PaginateEntityAsync($"/v1/products/{id}", request, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBProduct>> UpdateAsync(long id, UpdateProductRequest request, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync($"/v1/products/{id}", request, cancellationToken);
        }
    }
}
