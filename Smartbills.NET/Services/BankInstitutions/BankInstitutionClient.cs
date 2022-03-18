
using Smartbills.Client.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface IBankInstitutionClient :
    IRetrievable<SBBankInstitution, GetBankInstitutionRequest>,
        ICreateable<SBBankInstitution, CreateBankInstitutionRequest>,
        IUpdateable<SBBankInstitution, UpdateBankInstitutionRequest>

    {
    }
    public class BankInstitutionClient :
    Service<SBBankInstitution>, IBankInstitutionClient

    {
        public override string BasePath => "bank-institutions";

        public BankInstitutionClient(ISmartbillsClient client) : base(client) { }

        public async Task<SmartbillsResponse<SBBankInstitution>> GetAsync(Guid id, GetBankInstitutionRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBBankInstitution>> CreateAsync(CreateBankInstitutionRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(options, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBBankInstitution>> UpdateAsync(Guid id, UpdateBankInstitutionRequest updateRequest, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, updateRequest, requestOptions, cancellationToken);
        }
    }
}
