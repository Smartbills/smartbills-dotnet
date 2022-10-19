using Smartbills.NET.Entities.Banks;
using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services._base;
using Smartbills.NET.Services._interfaces;
using Smartbills.NET.Services.BankTransactions;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.BankAccounts
{
    public interface IBankAccountClient :
    IRetrievable<SBBankAccount>,
    IUpdatable<SBBankAccount, UpdateBankAccountRequest>,
    ICreatable<SBBankAccount, CreateBankAccountRequest>
    {
    }
    public class BankAccountClient : ClientBase<SBBankAccount>, IBankAccountClient

    {
        public override string BasePath => "bank-accounts";
        private string TransactionsPath => "accounts";


        public BankAccountClient(ISmartbillsClient client) : base(client) { }

        public async Task<SBBankAccount> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync(id, cancellationToken);
        }

        public async Task<SBBankAccount> UpdateAsync(long id, UpdateBankAccountRequest data, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync(id, data, cancellationToken);
        }

        public async Task<SBBankAccount> CreateAsync(CreateBankAccountRequest createRequest, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync(createRequest, cancellationToken);
        }

        public async Task<SBBankTransaction> GetTransactionsAsync(long parentId, long id, GetBankTransactionRequest options = null, CancellationToken cancellationToken = default)
        {
            return await GetChildByIdAsync<GetBankTransactionRequest, SBBankTransaction>(parentId, TransactionsPath, id, options, cancellationToken);
        }

        public async Task<SBBankTransaction> CreateTransactionsAsync(long parentId, CreateBankTransactionRequest data, CancellationToken cancellationToken = default)
        {
            return await CreateChildAsync<CreateBankTransactionRequest, SBBankTransaction>(parentId, TransactionsPath, data, cancellationToken);
        }
        public async Task<SBBankTransaction> UpdateTransactionsAsync(long parentId, long id, UpdateBankTransactionRequest data, CancellationToken cancellationToken = default)
        {
            return await UpdateChildAsync<UpdateBankTransactionRequest, SBBankTransaction>(parentId, TransactionsPath, id, data, cancellationToken);
        }

    }
}
