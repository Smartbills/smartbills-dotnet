
using Smartbills.Client.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

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
        public override string BasePath => "bank-accounts";
        public override string NestedPath => "banks/{PARENT_ID}/accounts";

        public BankAccountClient(ISmartbillsClient client) : base(client) { }

        public async Task<SmartbillsResponse<SBBankAccount>> GetAsync(long parentId, long id, GetBankAccountRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.GetNestedEntityAsync(parentId, id, options, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBBankAccount>> UpdateAsync(long parentId, long id, UpdateBankAccountRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateNestedEntityAsync(parentId, id, options, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBBankAccount>> CreateAsync(long parentId, CreateBankAccountRequest createRequest, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateNestedEntityAsync(parentId, createRequest, requestOptions, cancellationToken);
        }
    }
}
