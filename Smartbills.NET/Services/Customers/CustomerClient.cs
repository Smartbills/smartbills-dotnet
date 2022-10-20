using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Customers;
using Smartbills.NET.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Customers
{
    public interface ICustomerClient : ICreatable<SBCustomer, CreateCustomerRequest>,
    IRetrievable<SBCustomer>,
    IUpdatable<SBCustomer, UpdateCustomerRequest>,
    IDeletable<SBCustomer>
    {

    }
    public class CustomerClient: ClientBase<SBCustomer>
    {
        public CustomerClient(ISmartbillsClient client) : base(client)
        {
        }

        public override string BasePath => "merchants";
        private string CustomersPath => "customers";

        public async Task<SBCustomer> CreateAsync(long merchantId, CreateCustomerRequest request, CancellationToken cancellationToken = default)
        {
            return await base.CreateChildAsync<CreateCustomerRequest,SBCustomer>(merchantId, CustomersPath, request, cancellationToken);
        }

        public async Task<SBCustomer> DeleteAsync(long merchantId, long id, CancellationToken cancellationToken = default)
        {
            return await base.DeleteChildAsync<SBCustomer>(merchantId, CustomersPath, id, cancellationToken);
        }

        public async Task<SBCustomer> GetByIdAsync(long merchantId, long id, CancellationToken cancellationToken = default)
        {
            return await base.GetChildByIdAsync<SBCustomer>(merchantId, CustomersPath, id, cancellationToken);
        }

        public async Task<SBCustomer> UpdateAsync(long merchantId, long id, UpdateCustomerRequest request, CancellationToken cancellationToken = default)
        {
            return await base.UpdateChildAsync<UpdateCustomerRequest, SBCustomer>(merchantId, CustomersPath, id,request, cancellationToken);
        }
    }
}
