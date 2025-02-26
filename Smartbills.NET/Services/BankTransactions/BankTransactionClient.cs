using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Banks;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.BankTransactions
{
    public interface IBankTransactionClient :
    ICreatable<BankTransactionCreateRequest, SBBankTransaction>,
    IUpdatable<BankTransactionUpdateRequest, SBBankTransaction>,
    IRetrievable<SBBankTransaction>,


    IDeletable<SBBankTransaction>

    { }
    public class BankTransactionClient : Service<SBBankTransaction>, IBankTransactionClient
    {
        public BankTransactionClient(ISmartbillsClient client) : base(client)
        {
        }

        public async Task<SBBankTransaction> CreateAsync(BankTransactionCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/bank-transactions", request, options, cancellationToken);
        }


        public async Task<SBBankTransaction> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/bank-transactions/{id}", options, cancellationToken);
        }


        public async Task<SBBankTransaction> UpdateAsync(long id, BankTransactionUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/bank-transactions/{id}", request, options, cancellationToken);
        }



        public async Task<SBBankTransaction> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/bank-transactions/{id}", options, cancellationToken);
        }
    }
}