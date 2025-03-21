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

        public async Task<SBTax> CreateAsync(long merchantId, TaxCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/merchants/{merchantId}/taxes", request, options, cancellationToken);
        }

        public async Task<SBTax> DeleteAsync(long merchantId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/merchants/{merchantId}/taxes/{id}", options, cancellationToken);
        }

        public async Task<SBTax> GetByIdAsync(long merchantId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/merchants/{merchantId}/taxes/{id}", options, cancellationToken);
        }

        public async Task<SBTax> UpdateAsync(long merchantId, long id, TaxUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/merchants/{merchantId}/taxes/{id}", request, options, cancellationToken);
        }

        public async Task<SBList<SBTax>> ListAsync(long merchantId, TaxListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/merchants/{merchantId}/taxes", request, options, cancellationToken);
        }
    }
}
