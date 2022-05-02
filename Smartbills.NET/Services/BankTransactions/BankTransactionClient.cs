using Smartbills.Client.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface IBankTransactionClient :
    ICreateable<SBBankTransaction, CreateBankTransactionRequest>,
    IUpdateable<SBBankTransaction, UpdateBankTransactionRequest>,
    IRetrievable<SBBankTransaction, GetBankTransactionRequest>,
    INestedCreateable<SBBankTransaction, CreateBankTransactionRequest>,
    INestedRetrievable<SBBankTransaction, GetBankTransactionRequest>,
    INestedUpdateble<SBBankTransaction, UpdateBankTransactionRequest>,

    IDeleteable<SBBankTransaction, DeleteBankTransactionRequest>

    { }
    public class BankTransactionClient : ServiceNested<SBBankTransaction>, IBankTransactionClient
    {
        public BankTransactionClient(ISmartbillsClient client) : base(client)
        {
        }

        public override string BasePath => "bank-transactions";

        public override string NestedPath => "bank-accounts/{PARENT_ID}/transactions";


        public async Task<SmartbillsResponse<SBBankTransaction>> CreateAsync(CreateBankTransactionRequest createRequest, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(createRequest, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBBankTransaction>> CreateAsync(long parentId, CreateBankTransactionRequest createRequest, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateNestedEntityAsync(parentId, createRequest, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBBankTransaction>> GetAsync(long id, GetBankTransactionRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBBankTransaction>> GetAsync(long parentId, long id, GetBankTransactionRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.GetNestedEntityAsync(parentId, id, options, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBBankTransaction>> UpdateAsync(long id, UpdateBankTransactionRequest updateRequest, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, updateRequest, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBBankTransaction>> UpdateAsync(long parentId, long id, UpdateBankTransactionRequest updateRequest, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateNestedEntityAsync(parentId, id, updateRequest, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBBankTransaction>> DeleteAsync(long id, DeleteBankTransactionRequest deleteRequest, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync(id, deleteRequest, requestOptions, cancellationToken);
        }
    }
}