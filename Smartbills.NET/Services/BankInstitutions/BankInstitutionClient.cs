
using Microsoft.Extensions.Options;
using RestSharp;
using Smarbtills.NET.Services;
using Smartbills.Client.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface IBankInstitutionClient :
        IRetrievable<SBBankInstitution, GetBankInstitutionRequest>,
        ICreatable<SBBankInstitution, CreateBankInstitutionRequest>,
        IUpdatable<SBBankInstitution, UpdateBankInstitutionRequest>
    {
    }
    public class BankInstitutionClient : Service<SBBankInstitution>, IBankInstitutionClient
    {
        public override string BasePath => "bank-institutions";

        public BankInstitutionClient(ISmartbillsClient client) : base(client) { }

        public async Task<SBBankInstitution> GetAsync(long id, GetBankInstitutionRequest request = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync(id, request, cancellationToken);
        }

        public async Task<SBBankInstitution> CreateAsync(CreateBankInstitutionRequest options, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(options, cancellationToken);
        }

        public async Task<SBBankInstitution> UpdateAsync(long id, UpdateBankInstitutionRequest updateRequest, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, updateRequest, cancellationToken);
        }
    }
}
