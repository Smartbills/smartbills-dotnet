using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Fees;
using Smartbills.NET.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Fees
{
    public interface IFeeClient : 
        ICreatable<FeeCreateRequest, SBFee>,
        IUpdatable<FeeUpdateRequest, SBFee>,
        IDeletable<SBFee>,
        IRetrievable<SBFee>,
        IListable<ListRequest, List<SBFee>>
    {

    }
    public class FeeClient : Service<SBFee>, IFeeClient
    {

        public FeeClient(ISmartbillsClient client) : base(client)
        {

        }

        public async Task<SBFee> CreateAsync(FeeCreateRequest ListRequest, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync($"/v1/fees/", ListRequest, options, cancellationToken);
        }

        public async Task<SBFee> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/fees/{id}", options, cancellationToken);
        }

        public async Task<SBFee> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/fees/{id}", options, cancellationToken);
        }

        public async Task<List<SBFee>> ListAsync(ListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityAsync<ListRequest, List<SBFee>>($"/v1/fees/", request, options, cancellationToken);
        }

        public async Task<SBFee> UpdateAsync(long id, FeeUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/fees/{id}", request, options, cancellationToken);
        }
    }
}
