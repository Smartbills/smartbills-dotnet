using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Customers;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Customers
{
    public interface ICustomerClient :

        ICreatable<CreateCustomerRequest, SBCustomer>,
    IRetrievable<SBCustomer>,
    IUpdatable<UpdateCustomerRequest, SBCustomer>,
    IDeletable<SBCustomer>,
        IListable<ListCustomersRequest, PaginatedResponse<SBCustomer>>
    {

    }
    public class CustomerClient : Service<SBCustomer>, ICustomerClient
    {
        public CustomerClient(ISmartbillsClient client) : base(client)
        {
        }

        public async Task<SBCustomer> CreateAsync(CreateCustomerRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync<CreateCustomerRequest, SBCustomer>($"/v1/customers", request, options, cancellationToken);
        }

        public async Task<SBCustomer> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync($"/v1/customers/{id}", options, cancellationToken);
        }

        public async Task<SBCustomer> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync($"/v1/customers/{id}", options, cancellationToken);
        }

        public async Task<SBCustomer> UpdateAsync(long id, UpdateCustomerRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync($"/v1/customers/{id}", request, options, cancellationToken);
        }

        public async Task<PaginatedResponse<SBCustomer>> ListAsync(ListCustomersRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityAsync<ListCustomersRequest, PaginatedResponse<SBCustomer>>("/v1/customers", request, options, cancellationToken);
        }
    }
}
