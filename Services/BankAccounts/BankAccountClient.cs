
using System;
using System.Threading;
using System.Threading.Tasks;
using Smartbills.Client.Entities;

namespace Smartbills.Client.Services
{
    public interface IBankAccountClient :
    INestedRetrievable<SBBankAccount, GetBankAccountRequest>,
    INestedUpdateble<SBBankAccount, UpdateBankAccountRequest>,
    INestedCreateable<SBBankAccount, CreateBankAccountRequest>
    {
    }
    public class BankAccountClient :
    ServiceNested<SBBankAccount>, IBankAccountClient

    {
        public override string BasePath => "v1/bank-accounts";
        public override string NestedPath => "v1/banks/{PARENT_ID}/accounts";

        public BankAccountClient(ISmartbillsClient client) : base(client) { }

        public async Task<SmartbillsResponse<SBBankAccount>> GetAsync(Guid parentId, Guid id, GetBankAccountRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.GetNestedEntityAsync(parentId, id, options, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBBankAccount>> UpdateAsync(Guid parentId, Guid id, UpdateBankAccountRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateNestedEntityAsync(parentId, id, options, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBBankAccount>> CreateAsync(Guid parentId, CreateBankAccountRequest createRequest, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateNestedEntityAsync(parentId, createRequest, requestOptions, cancellationToken);
        }
    }
}
