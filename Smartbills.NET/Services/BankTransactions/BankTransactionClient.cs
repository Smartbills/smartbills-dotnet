using RestSharp;
using Smarbtills.NET.Services;
using Smartbills.Client.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface IBankTransactionClient :
    ICreatable<SBBankTransaction, CreateBankTransactionRequest>,
    IUpdatable<SBBankTransaction, UpdateBankTransactionRequest>,
    IRetrievable<SBBankTransaction, GetBankTransactionRequest>,


    IDeletable<SBBankTransaction, DeleteBankTransactionRequest>

    { }
    public class BankTransactionClient : Service<SBBankTransaction>, IBankTransactionClient
    {
        public BankTransactionClient(SmartbillsClient client) : base(client)
        {
        }

        public override string BasePath => "bank-transactions";


        public async Task<SBBankTransaction> CreateAsync(CreateBankTransactionRequest data, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(data, cancellationToken);
        }


        public async Task<SBBankTransaction> GetAsync(long id, GetBankTransactionRequest request, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync(id, request, cancellationToken);
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