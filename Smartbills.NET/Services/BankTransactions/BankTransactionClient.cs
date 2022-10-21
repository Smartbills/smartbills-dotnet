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

        public override string BasePath => "bank-transactions";


        public async Task<SBBankTransaction> CreateAsync(CreateBankTransactionRequest data, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync(data, cancellationToken);
        }


        public async Task<SBBankTransaction> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync(id, cancellationToken);
        }


        public async Task<SBBankTransaction> UpdateAsync(long id, UpdateBankTransactionRequest data, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync(id, data, cancellationToken);
        }



        public async Task<SBBankTransaction> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync(id, cancellationToken);
        }
    }
}