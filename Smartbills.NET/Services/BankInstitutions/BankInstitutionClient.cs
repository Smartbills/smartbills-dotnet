using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Banks;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.BankInstitutions
{
    public interface IBankInstitutionClient :
        IRetrievable<SBBankInstitution>,
        ICreatable<CreateBankInstitutionRequest, SBBankInstitution>,
        IUpdatable<UpdateBankInstitutionRequest, SBBankInstitution>
    {
    }
    public class BankInstitutionClient : ClientBase<SBBankInstitution>, IBankInstitutionClient
    {
        public BankInstitutionClient(ISmartbillsClient smartbills) : base(smartbills)
        {
        }


        public BankInstitutionClient(SBClientCredentials credentials) : base(credentials)
        {
        }

        public BankInstitutionClient(string accessToken, string url = "https://api.smartbills.io") : base(accessToken, url)
        {
        }

        public BankInstitutionClient(string apiKey, string apiSecret, string url = "https://api.smartbills.io") : base(apiKey, apiSecret, url)
        {
        }

        public virtual async Task<SmartbillsResponse<SBBankInstitution>> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/bank-institutions/{id}", cancellationToken);
        }

        public virtual async Task<SmartbillsResponse<SBBankInstitution>> CreateAsync(CreateBankInstitutionRequest request, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/bank-institutions", request, cancellationToken);
        }

        public virtual async Task<SmartbillsResponse<SBBankInstitution>> UpdateAsync(long id, UpdateBankInstitutionRequest updateRequest, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/bank-institutions/{id}", updateRequest, cancellationToken);
        }
    }
}
