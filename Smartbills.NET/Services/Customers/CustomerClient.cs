using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Customers;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Customers
{
    public interface ICustomerClient : IMerchantClientBase,
        
        ICreatable<CreateCustomerRequest, SBCustomer>,
    IRetrievable<SBCustomer>,
    IUpdatable<UpdateCustomerRequest, SBCustomer>,
    IDeletable<SBCustomer>,
        IListable<ListCustomersRequest, PaginatedResponse<SBCustomer>>
    {

    }
    public class CustomerClient: MerchantClientBase<SBCustomer>, ICustomerClient
    {
        public CustomerClient(ISmartbillsClient client) : base(client)
        {
        }


        public CustomerClient(long merchantId, string accessToken, string url = "https://api.smartbills.io") : base(merchantId, accessToken, url)
        {
        }

        public CustomerClient(long merchantId, string apiKey, string apiSecret, string url = "https://api.smartbills.io") : base(merchantId, apiKey, apiSecret, url)
        {
        }

        public CustomerClient(long merchantId, SBClientCredentials credentials, string url = "https://api.smartbills.io") : base(merchantId, credentials, url)
        {
        }

        public async Task<SBCustomer> CreateAsync(CreateCustomerRequest request, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync<CreateCustomerRequest,SBCustomer>($"/v1/customers", request, cancellationToken);
        }

        public async Task<SBCustomer> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync($"/v1/customers/{id}", cancellationToken);
        }

        public async Task<SBCustomer> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync($"/v1/customers/{id}", cancellationToken);
        }

        public async Task<SBCustomer> UpdateAsync(long id, UpdateCustomerRequest request, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync($"/v1/customers/{id}",request, cancellationToken);
        }

        public async Task<PaginatedResponse<SBCustomer>> ListAsync(ListCustomersRequest request, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityAsync<ListCustomersRequest, PaginatedResponse<SBCustomer>>("/v1/customers", request, cancellationToken);
        }
    }
}
