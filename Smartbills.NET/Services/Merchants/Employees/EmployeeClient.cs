using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Employees;
using Smartbills.NET.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Merchants.Employees
{
    public interface IEmployeeClient :
        INestedCreatable<EmployeeCreateRequest, SBEmployee>,
        INestedRetrievable<SBEmployee>,
        INestedUpdatable<EmployeeUpdateRequest, SBEmployee>,
        INestedDeletable<SBEmployee>,
        INestedListable<EmployeeListRequest, SBEmployee>,
        INestedBatchCreate<EmployeeCreateRequest, SBEmployee>,
        INestedBatchUpdate<EmployeeBatchItemUpdateRequest, SBEmployee>
    { }

    public class EmployeeClient : Service<SBEmployee>, IEmployeeClient
    {
        public EmployeeClient(ISmartbillsClient client) : base(client)
        {
        }

        public async Task<SBEmployee> CreateAsync(long merchantId, EmployeeCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/merchants/{merchantId}/employees", request, options, cancellationToken);
        }

        public async Task<SBEmployee> DeleteAsync(long merchantId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/merchants/{merchantId}/employees/{id}", options, cancellationToken);
        }

        public async Task<SBEmployee> GetByIdAsync(long merchantId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/merchants/{merchantId}/employees/{id}", options, cancellationToken);
        }

        public async Task<SBEmployee> UpdateAsync(long merchantId, long id, EmployeeUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/merchants/{merchantId}/employees/{id}", request, options, cancellationToken);
        }

        public async Task<SBList<SBEmployee>> ListAsync(long merchantId, EmployeeListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/merchants/{merchantId}/employees", request, options, cancellationToken);
        }

        public async Task<List<SBEmployee>> BatchCreateAsync(long merchantId, List<EmployeeCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<List<EmployeeCreateRequest>, List<SBEmployee>>($"/v1/merchants/{merchantId}/employees/batch", request, options, cancellationToken);
        }

        public async Task<List<SBEmployee>> BatchUpdateAsync(long merchantId, List<EmployeeBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<List<EmployeeBatchItemUpdateRequest>, List<SBEmployee>>($"/v1/merchants/{merchantId}/employees/batch", request, options, cancellationToken);
        }
    }
}
