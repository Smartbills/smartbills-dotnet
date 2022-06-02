
using Microsoft.Extensions.Options;
using RestSharp;
using Smarbtills.NET.Services;
using Smartbills.Client.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface IBankClient :
    ICreatable<SBBank, CreateBankRequest>,
    IRetrievable<SBBank, GetBankRequest>,
    IUpdatable<SBBank, UpdateBankRequest>,
    IDeletable<SBBank, DeleteBankRequest>
    {
    }
    public class BankClient : Service<SBBank>, IBankClient
    {
        public override string BasePath => "banks";
        private readonly string AccountsPath = "accounts";


        public BankClient(ISmartbillsClient client) : base(client) {
        }

        public async Task<SBBank> CreateAsync(CreateBankRequest data, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(data, cancellationToken);
        }
        public async Task<SBBank> GetAsync(long id, GetBankRequest data = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync(id, data, cancellationToken);
        }
        public async Task<SBBank> UpdateAsync(long id, UpdateBankRequest data, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, data, cancellationToken);
        }

        public async Task<SBBank> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync(id, cancellationToken);
        }


        public async Task<SBBankAccount> GetAccountAsync(long parentId, long id, GetBankAccountRequest request, CancellationToken cancellationToken = default)
        {
            return await base.GetChildByIdAsync<GetBankAccountRequest, SBBankAccount>(parentId, this.AccountsPath, id, request, cancellationToken);
        }

        public async Task<SBBankAccount> UpdateAccountAsync(long parentId, long id, UpdateBankAccountRequest data, CancellationToken cancellationToken = default)
        {
            return await base.UpdateChildAsync<UpdateBankAccountRequest, SBBankAccount>(parentId, this.AccountsPath, id, data, cancellationToken);
        }

        public async Task<SBBankAccount> CreateAccountAsync(long parentId, CreateBankAccountRequest data, CancellationToken cancellationToken = default)
        {
            return await base.CreateChildAsync<CreateBankAccountRequest, SBBankAccount>(parentId, this.AccountsPath, data, cancellationToken);
        }

    }
}
