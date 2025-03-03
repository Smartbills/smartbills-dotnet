﻿using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Customers;
using Smartbills.NET.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Customers
{
    public interface ICustomerClient :

        ICreatable<CustomerCreateRequest, SBCustomer>,
        IRetrievable<SBCustomer>,
        IUpdatable<CustomerUpdateRequest, SBCustomer>,
        IDeletable<SBCustomer>,
        IListable<CustomersListRequest, PaginatedResponse<SBCustomer>>,
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
            return await base.CreateEntityAsync<CustomerCreateRequest, SBCustomer>($"/v1/customers", request, options, cancellationToken);
        }

        public async Task<SBCustomer> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync($"/v1/customers/{id}", options, cancellationToken);
        }

        public async Task<SBCustomer> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync($"/v1/customers/{id}", options, cancellationToken);
        }

        public async Task<SBCustomer> UpdateAsync(long id, CustomerUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync($"/v1/customers/{id}", request, options, cancellationToken);
        }

        public async Task<PaginatedResponse<SBCustomer>> ListAsync(CustomersListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityAsync<CustomersListRequest, PaginatedResponse<SBCustomer>>("/v1/customers", request, options, cancellationToken);
        }

        public async Task<List<SBCustomer>> BatchCreateAsync(List<CustomerCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync<List<CustomerCreateRequest>, List<SBCustomer>>("/v1/customers/batch", request, options, cancellationToken);
        }

        public async Task<List<SBCustomer>> BatchUpdateAsync(List<CustomerBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync<List<CustomerBatchItemUpdateRequest>, List<SBCustomer>>("/v1/customers/batch", request, options, cancellationToken);
        }
    }
}
