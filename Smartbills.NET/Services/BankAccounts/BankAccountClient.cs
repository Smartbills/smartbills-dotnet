using Smartbills.NET.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services
{
    public interface IBankAccountClient :
    IRetrievable<SBBankAccount, GetBankAccountRequest>,
    IUpdatable<SBBankAccount, UpdateBankAccountRequest>,
    ICreatable<SBBankAccount, CreateBankAccountRequest>
    {
    }
    public class BankAccountClient : ClientBase<SBBankAccount>, IBankAccountClient

    {
        public override string BasePath => "bank-accounts";
        private string TransactionsPath => "accounts";


        public BankAccountClient(ISmartbillsClient client) : base(client) { }

        public async Task<SBBankAccount> GetAsync(long id, GetBankAccountRequest data, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync(id, data, cancellationToken);
        }

        public async Task<SBBankAccount> UpdateAsync(long id, UpdateBankAccountRequest data, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, data, cancellationToken);
        }

        public async Task<SBBankAccount> CreateAsync(CreateBankAccountRequest createRequest, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(createRequest, cancellationToken);
        }

        public async Task<SBBankTransaction> GetTransactionsAsync(long parentId, long id, GetBankTransactionRequest options = null, CancellationToken cancellationToken = default)
        {
            return await base.GetChildByIdAsync<GetBankTransactionRequest, SBBankTransaction>(parentId, this.TransactionsPath, id, options, cancellationToken);
        }

        public async Task<SBBankTransaction> CreateTransactionsAsync(long parentId, CreateBankTransactionRequest data, CancellationToken cancellationToken = default)
        {
            return await base.CreateChildAsync<CreateBankTransactionRequest, SBBankTransaction>(parentId, this.TransactionsPath, data, cancellationToken);
        }
        public async Task<SBBankTransaction> UpdateTransactionsAsync(long parentId, long id, UpdateBankTransactionRequest data, CancellationToken cancellationToken = default)
        {
            return await base.UpdateChildAsync<UpdateBankTransactionRequest, SBBankTransaction>(parentId, this.TransactionsPath, id, data, cancellationToken);
        }

    }
}
