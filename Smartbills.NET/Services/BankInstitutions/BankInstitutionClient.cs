using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Banks;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.BankInstitutions
{
    public interface IBankInstitutionClient :
        IRetrievable<SBBankInstitution>,
        ICreatable<SBBankInstitution, CreateBankInstitutionRequest>,
        IUpdatable<SBBankInstitution, UpdateBankInstitutionRequest>
    {
    }
    public class BankInstitutionClient : ClientBase<SBBankInstitution>, IBankInstitutionClient
    {
        public override string BasePath => "bank-institutions";

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

        public virtual async Task<SBBankInstitution> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync(id, cancellationToken);
        }

        public virtual async Task<SBBankInstitution> CreateAsync(CreateBankInstitutionRequest options, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync(options, cancellationToken);
        }

        public virtual async Task<SBBankInstitution> UpdateAsync(long id, UpdateBankInstitutionRequest updateRequest, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync(id, updateRequest, cancellationToken);
        }
    }
}
