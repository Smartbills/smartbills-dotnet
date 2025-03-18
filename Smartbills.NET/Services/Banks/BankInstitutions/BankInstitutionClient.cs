using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Banks;
using Smartbills.NET.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Banks.BankInstitutions
{
    public interface IBankInstitutionClient :
        IRetrievableById<SBBankInstitution>,
        IListable<BankInstitutionListRequest, SBBankInstitution>
    {
    }
    public class BankInstitutionClient : Service<SBBankInstitution>, IBankInstitutionClient
    {
        public BankInstitutionClient(ISmartbillsClient smartbills) : base(smartbills)
        {
        }


        public async Task<SBBankInstitution> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/bank-institutions/{id}", options, cancellationToken);
        }

        public async Task<SBList<SBBankInstitution>> ListAsync(BankInstitutionListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/bank-institutions", request, options, cancellationToken);
        }
    }
}
