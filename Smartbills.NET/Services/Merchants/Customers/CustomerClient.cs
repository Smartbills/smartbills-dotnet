using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Customers;
using Smartbills.NET.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Merchants.Customers
{
    public interface ICustomerClient :

        ICreatable<CustomerCreateRequest, SBCustomer>,
        IRetrievableById<SBCustomer>,
        IUpdatable<CustomerUpdateRequest, SBCustomer>,
        IDeletable<SBCustomer>,
        IListable<CustomerListRequest, SBCustomer>,
        IBatchCreate<CustomerCreateRequest, SBCustomer>,
        IBatchUpdate<CustomerBatchItemUpdateRequest, SBCustomer>
    {

    }
    public class CustomerClient : Service<SBCustomer>, ICustomerClient
    {
        public CustomerClient(ISmartbillsClient client) : base(client)
        {
        }

        public async Task<SBCustomer> CreateAsync(CustomerCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<CustomerCreateRequest, SBCustomer>($"/v1/customers", request, options, cancellationToken);
        }

        public async Task<SBCustomer> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/customers/{id}", options, cancellationToken);
        }

        public async Task<SBCustomer> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/customers/{id}", options, cancellationToken);
        }

        public async Task<SBCustomer> UpdateAsync(long id, CustomerUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/customers/{id}", request, options, cancellationToken);
        }

        public async Task<SBList<SBCustomer>> ListAsync(CustomerListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityAsync<CustomerListRequest, SBList<SBCustomer>>("/v1/customers", request, options, cancellationToken);
        }

        public async Task<List<SBCustomer>> BatchCreateAsync(List<CustomerCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<List<CustomerCreateRequest>, List<SBCustomer>>("/v1/customers/batch", request, options, cancellationToken);
        }

        public async Task<List<SBCustomer>> BatchUpdateAsync(List<CustomerBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<List<CustomerBatchItemUpdateRequest>, List<SBCustomer>>("/v1/customers/batch", request, options, cancellationToken);
        }
    }
}
