using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Taxes;
using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services.Taxes;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Merchants.Taxes
{
    public interface ITaxClient :
        INestedCreatable<TaxCreateRequest, SBTax>,
        INestedUpdatable<TaxUpdateRequest, SBTax>,
        INestedDeletable<SBTax>,
        INestedRetrievable<SBTax>,
        INestedListable<TaxListRequest, SBTax>
    { }

    public class TaxClient : Service<SBTax>, ITaxClient
    {
        public TaxClient(ISmartbillsClient smartbills) : base(smartbills)
        {
        }

        public async Task<SBTax> CreateAsync(long businessId, TaxCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/businesses/{businessId}/taxes", request, options, cancellationToken);
        }

        public async Task<SBTax> DeleteAsync(long businessId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/businesses/{businessId}/taxes/{id}", options, cancellationToken);
        }

        public async Task<SBTax> GetByIdAsync(long businessId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/businesses/{businessId}/taxes/{id}", options, cancellationToken);
        }

        public async Task<SBTax> UpdateAsync(long businessId, long id, TaxUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/businesses/{businessId}/taxes/{id}", request, options, cancellationToken);
        }

        public async Task<SBList<SBTax>> ListAsync(long businessId, TaxListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/businesses/{businessId}/taxes", request, options, cancellationToken);
        }
    }
}
