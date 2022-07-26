using Smartbills.NET.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services
{
    public interface IBankTransactionClient :
    ICreatable<SBBankTransaction, CreateBankTransactionRequest>,
    IUpdatable<SBBankTransaction, UpdateBankTransactionRequest>,
    IRetrievable<SBBankTransaction>,


    IDeletable<SBBankTransaction, DeleteBankTransactionRequest>

    { }
    public class BankTransactionClient : ClientBase<SBBankTransaction>, IBankTransactionClient
    {
        public BankTransactionClient(ISmartbillsClient client) : base(client)
        {
        }

        public override string BasePath => "bank-transactions";


        public async Task<SBBankTransaction> CreateAsync(CreateBankTransactionRequest data, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(data, cancellationToken);
        }


        public async Task<SBBankTransaction> GetByIdAsync(long id,  CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync(id,  cancellationToken);
        }


        public async Task<SBBankTransaction> UpdateAsync(long id, UpdateBankTransactionRequest data, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, data, cancellationToken);
        }



        public async Task<SBBankTransaction> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync(id, cancellationToken);
        }
    }
}