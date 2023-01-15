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
    IUpdatable<UpdateBankAccountRequest, SBBankAccount>,
    ICreatable<CreateBankAccountRequest, SBBankAccount>
    {
        Task<SBBankTransaction> GetTransactionsAsync(long id, GetBankTransactionRequest request = null, CancellationToken cancellationToken = default);
        Task<SBBankTransaction> CreateTransactionsAsync(long id, CreateBankTransactionRequest request, CancellationToken cancellationToken = default);
        Task<SBBankTransaction> UpdateTransactionsAsync(long id, UpdateBankTransactionRequest request, CancellationToken cancellationToken = default);

    }
    public class BankAccountClient : UserClientBase<SBBankAccount>, IBankAccountClient

    {

        public BankAccountClient(ISmartbillsClient client) : base(client)
        {
        }

        public BankAccountClient(string accessToken, string url = "https://api.smartbills.io") : base(accessToken, url)
        {
        }

        public async Task<SBBankAccount> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/bank-accounts/{id}", cancellationToken);
        }

        public async Task<SBBankAccount> UpdateAsync(long id, UpdateBankAccountRequest request, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/bank-accounts/{id}", request, cancellationToken);
        }

        public async Task<SBBankAccount> CreateAsync(CreateBankAccountRequest createRequest, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/bank-accounts", createRequest, cancellationToken);
        }

        public async Task<SBBankTransaction> GetTransactionsAsync(long id, GetBankTransactionRequest request = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityAsync<GetBankTransactionRequest, SBBankTransaction>($"/v1/bank-accounts/{id}/transactions", request, cancellationToken);
        }

        public async Task<SBBankTransaction> CreateTransactionsAsync(long id, CreateBankTransactionRequest request, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<CreateBankTransactionRequest, SBBankTransaction>($"/v1/bank-accounts/{id}/transactions", request, cancellationToken);
        }
        public async Task<SBBankTransaction> UpdateTransactionsAsync(long id, UpdateBankTransactionRequest request, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<UpdateBankTransactionRequest, SBBankTransaction>($"/v1/bank-accounts/{id}/transactions", request, cancellationToken);
        }

    }
}
