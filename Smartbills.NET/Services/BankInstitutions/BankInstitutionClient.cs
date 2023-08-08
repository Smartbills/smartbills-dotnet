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
    public class BankInstitutionClient : Service<SBBankInstitution>, IBankInstitutionClient
    {
        public BankInstitutionClient(ISmartbillsClient smartbills) : base(smartbills)
        {
        }


        public virtual async Task<SBBankInstitution> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/bank-institutions/{id}", options, cancellationToken);
        }

        public virtual async Task<SBBankInstitution> CreateAsync(CreateBankInstitutionRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/bank-institutions", request, options, cancellationToken);
        }

        public virtual async Task<SBBankInstitution> UpdateAsync(long id, UpdateBankInstitutionRequest updateRequest, SBRequestOptions options= null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/bank-institutions/{id}", updateRequest, options, cancellationToken);
        }
    }
}
