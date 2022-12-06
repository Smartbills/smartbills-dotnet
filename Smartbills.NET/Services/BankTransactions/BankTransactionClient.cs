using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Banks;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.BankTransactions
{
    public interface IBankTransactionClient :
    ICreatable<CreateBankTransactionRequest, SBBankTransaction>,
    IUpdatable<UpdateBankTransactionRequest, SBBankTransaction>,
    IRetrievable<SBBankTransaction>,


    IDeletable<SBBankTransaction>

    { }
    public class BankTransactionClient : ClientBase<SBBankTransaction>, IBankTransactionClient
    {
        public BankTransactionClient(ISmartbillsClient client) : base(client)
        {
        }

        public async Task<SmartbillsResponse<SBBankTransaction>> CreateAsync(CreateBankTransactionRequest request, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/bank/transactions", request, cancellationToken);
        }


        public async Task<SmartbillsResponse<SBBankTransaction>> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/bank/transactions/{id}", cancellationToken);
        }


        public async Task<SmartbillsResponse<SBBankTransaction>> UpdateAsync(long id, UpdateBankTransactionRequest request, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/bank/transactions/{id}", request, cancellationToken);
        }



        public async Task<SmartbillsResponse<SBBankTransaction>> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/bank/transactions/{id}", cancellationToken);
        }
    }
}