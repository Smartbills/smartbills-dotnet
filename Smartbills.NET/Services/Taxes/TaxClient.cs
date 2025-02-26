using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Taxes;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Taxes
{
    public interface ITaxClient : ICreatable<TaxCreateRequest, SBTax>, IUpdatable<TaxUpdateRequest, SBTax>, IDeletable<SBTax>, IRetrievable<SBTax> { }
    public class TaxClient : Service<SBTax>, ITaxClient
    {
        public TaxClient(ISmartbillsClient smartbills) : base(smartbills)
        {
        }

        public async Task<SBTax> CreateAsync(TaxCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/taxes", request, options, cancellationToken);
        }

        public async Task<SBTax> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/taxes/{id}", options, cancellationToken);
        }

        public async Task<SBTax> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/taxes/{id}", options, cancellationToken);
        }

        public async Task<SBTax> UpdateAsync(long id, TaxUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/taxes/{id}", request, options, cancellationToken);
        }
    }
}
