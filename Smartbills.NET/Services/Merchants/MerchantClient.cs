using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Merchants;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Merchants
{
    public interface IMerchantClient :
    IRetrievable<SBMerchant>,
    ICreatable<CreateMerchantRequest,SBMerchant>,
    IUpdatable<UpdateMerchantRequest, SBMerchant>
    {
    }
    public class MerchantClient :
    ClientBase<SBMerchant>,
        IMerchantClient

    {
        public override string BasePath => "merchants";

        public MerchantClient(ISmartbillsClient smartbills) : base(smartbills)
        {
        }

        public MerchantClient(SBClientCredentials credentials) : base(credentials)
        {
        }

        public MerchantClient(string accessToken, string url = "https://api.smartbills.io") : base(accessToken, url)
        {
        }

        public MerchantClient(string apiKey, string apiSecret, string url = "https://api.smartbills.io") : base(apiKey, apiSecret, url)
        {
        }

        public async Task<SBMerchant> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync(id, cancellationToken);
        }

        public async Task<SBMerchant> CreateAsync(CreateMerchantRequest request, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync(request, cancellationToken);
        }

        public async Task<SBMerchant> UpdateAsync(long id, UpdateMerchantRequest request, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync(id, request, cancellationToken);
        }
    }
}
