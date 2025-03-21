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
        INestedCreatable<CustomerCreateRequest, SBCustomer>,
        INestedRetrievable<SBCustomer>,
        INestedUpdatable<CustomerUpdateRequest, SBCustomer>,
        INestedDeletable<SBCustomer>,
        INestedListable<CustomerListRequest, SBCustomer>,
        INestedBatchCreate<CustomerCreateRequest, SBCustomer>,
        INestedBatchUpdate<CustomerBatchItemUpdateRequest, SBCustomer>
    { }

    public class CustomerClient : Service<SBCustomer>, ICustomerClient
    {
        public CustomerClient(ISmartbillsClient client) : base(client)
        {
        }

        public async Task<SBCustomer> CreateAsync(long merchantId, CustomerCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/merchants/{merchantId}/customers", request, options, cancellationToken);
        }

        public async Task<SBCustomer> DeleteAsync(long merchantId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/merchants/{merchantId}/customers/{id}", options, cancellationToken);
        }

        public async Task<SBCustomer> GetByIdAsync(long merchantId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/merchants/{merchantId}/customers/{id}", options, cancellationToken);
        }

        public async Task<SBCustomer> UpdateAsync(long merchantId, long id, CustomerUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/merchants/{merchantId}/customers/{id}", request, options, cancellationToken);
        }

        public async Task<SBList<SBCustomer>> ListAsync(long merchantId, CustomerListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/merchants/{merchantId}/customers", request, options, cancellationToken);
        }

        public async Task<List<SBCustomer>> BatchCreateAsync(long merchantId, List<CustomerCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<List<CustomerCreateRequest>, List<SBCustomer>>($"/v1/merchants/{merchantId}/customers/batch", request, options, cancellationToken);
        }

        public async Task<List<SBCustomer>> BatchUpdateAsync(long merchantId, List<CustomerBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<List<CustomerBatchItemUpdateRequest>, List<SBCustomer>>($"/v1/merchants/{merchantId}/customers/batch", request, options, cancellationToken);
        }
    }
}
