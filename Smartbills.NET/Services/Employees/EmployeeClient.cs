using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Employees;
using Smartbills.NET.Entities;
using Smartbills.NET.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Employees
{
    public interface IEmployeeClient : 
        ICreatable<EmployeeCreateRequest, SBEmployee>,
        IUpdatable<EmployeeUpdateRequest, SBEmployee>,
        IDeletable<SBEmployee>,
        IRetrievable<SBEmployee>,
        IListable<ListRequest, List<SBEmployee>>,
        IBatchCreate<EmployeeCreateRequest, SBEmployee>,
        IBatchUpdate<EmployeeBatchItemUpdateRequest, SBEmployee>
    {

    }
    public class EmployeeClient : Service<SBEmployee>, IEmployeeClient
    {

        public EmployeeClient(ISmartbillsClient client) : base(client)
        {

        }

        public async Task<SBEmployee> CreateAsync(EmployeeCreateRequest ListRequest, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync($"/v1/employees/", ListRequest, options, cancellationToken);
        }

        public async Task<SBEmployee> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/employees/{id}", options, cancellationToken);
        }

        public async Task<SBEmployee> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/employees/{id}", options, cancellationToken);
        }

        public async Task<List<SBEmployee>> ListAsync(ListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityAsync<ListRequest, List<SBEmployee>>($"/v1/employees/", request, options, cancellationToken);
        }

        public async Task<SBEmployee> UpdateAsync(long id, EmployeeUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/employees/{id}", request, options, cancellationToken);
        }
        public async Task<List<SBEmployee>> BatchCreateAsync(List<EmployeeCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync<List<EmployeeCreateRequest>, List<SBEmployee>>("/v1/employees/batch", request, options, cancellationToken);
        }

        public async Task<List<SBEmployee>> BatchUpdateAsync(List<EmployeeBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync<List<EmployeeBatchItemUpdateRequest>, List<SBEmployee>>("/v1/employees/batch", request, options, cancellationToken);
        }
    }
}
