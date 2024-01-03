using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Banks;
using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services.BankTransactions;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.BankAccounts
{
    public interface IBankAccountClient :
    IRetrievable<SBBankAccount>,
    IUpdatable<BankAccountUpdateRequest, SBBankAccount>,
    ICreatable<BankAccountCreateRequest, SBBankAccount>
    {
        Task<SBBankTransaction> GetTransactionsAsync(long id, BankTransactionListRequest request = null, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBBankTransaction> CreateTransactionsAsync(long id, BankTransactionCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBBankTransaction> UpdateTransactionsAsync(long id, BankTransactionUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);

    }
    public class BankAccountClient : Service<SBBankAccount>, IBankAccountClient

    {

        public BankAccountClient(ISmartbillsClient client) : base(client)
        {
        }

        public async Task<SBBankAccount> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/bank-accounts/{id}", options, cancellationToken);
        }

        public async Task<SBBankAccount> UpdateAsync(long id, BankAccountUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/bank-accounts/{id}", request, options, cancellationToken);
        }

        public async Task<SBBankAccount> CreateAsync(BankAccountCreateRequest ListRequest, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/bank-accounts", ListRequest, options, cancellationToken);
        }

        public async Task<SBBankTransaction> GetTransactionsAsync(long id, BankTransactionListRequest request = null, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityAsync<BankTransactionListRequest, SBBankTransaction>($"/v1/bank-accounts/{id}/transactions", request, options, cancellationToken);
        }

        public async Task<SBBankTransaction> CreateTransactionsAsync(long id, BankTransactionCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<BankTransactionCreateRequest, SBBankTransaction>($"/v1/bank-accounts/{id}/transactions", request, options, cancellationToken);
        }
        public async Task<SBBankTransaction> UpdateTransactionsAsync(long id, BankTransactionUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<BankTransactionUpdateRequest, SBBankTransaction>($"/v1/bank-accounts/{id}/transactions", request, options, cancellationToken);
        }

    }
}
