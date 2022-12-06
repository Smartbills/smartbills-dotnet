using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Taxes;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Taxes
{
    public interface ITaxClient : IMerchantClientBase, ICreatable<CreateTaxRequest, SBTax>, IUpdatable<UpdateTaxRequest, SBTax>, IDeletable<SBTax>, IRetrievable<SBTax> { }
    public class TaxClient : MerchantClientBase<SBTax>, ITaxClient
    {
        public TaxClient(ISmartbillsClient smartbills) : base(smartbills)
        {
        }

        public TaxClient(long merchantId, SBClientCredentials credentials, string url = "https://api.smartbills.io") : base(merchantId, credentials, url)
        {
        }

        public TaxClient(long merchantId, string accessToken, string url = "https://api.smartbills.io") : base(merchantId, accessToken, url)
        {
        }

        public TaxClient(long merchantId, string apiKey, string apiSecret, string url = "https://api.smartbills.io") : base(merchantId, apiKey, apiSecret, url)
        {
        }

        public async Task<SmartbillsResponse<SBTax>> CreateAsync(CreateTaxRequest request, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/taxes", request, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBTax>> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/taxes/{id}", cancellationToken);
        }

        public async Task<SmartbillsResponse<SBTax>> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/taxes/{id}", cancellationToken);
        }

        public async Task<SmartbillsResponse<SBTax>> UpdateAsync(long id, UpdateTaxRequest request, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/taxes/{id}", request, cancellationToken);
        }
    }
}
