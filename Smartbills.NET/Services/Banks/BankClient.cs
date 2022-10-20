using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Banks;
using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services.BankAccounts;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Banks
{
    public interface IBankClient :
    ICreatable<SBBank, CreateBankRequest>,
    IRetrievable<SBBank>,
    IUpdatable<SBBank, UpdateBankRequest>,
    IDeletable<SBBank>
    {
        Task<SBBankAccount> GetAccountAsync(long parentId, long id, GetBankAccountRequest request, CancellationToken cancellationToken = default);
        Task<SBBankAccount> UpdateAccountAsync(long parentId, long id, UpdateBankAccountRequest data, CancellationToken cancellationToken = default);
        Task<SBBankAccount> CreateAccountAsync(long parentId, CreateBankAccountRequest data, CancellationToken cancellationToken = default);
    }
    public class BankClient : ClientBase<SBBank>, IBankClient
    {
        public override string BasePath => "banks";
        private readonly string AccountsPath = "accounts";

        public BankClient(ISmartbillsClient smartbills) : base(smartbills)
        {
        }

        public BankClient(SBClientCredentials credentials) : base(credentials)
        {
        }

        public BankClient(string accessToken, string url = "https://api.smartbills.io") : base(accessToken, url)
        {
        }

        public BankClient(string apiKey, string apiSecret, string url = "https://api.smartbills.io") : base(apiKey, apiSecret, url)
        {
        }

        public virtual async Task<SBBank> CreateAsync(CreateBankRequest data, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync(data, cancellationToken);
        }
        public virtual async Task<SBBank> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync(id, cancellationToken);
        }
        public virtual async Task<SBBank> UpdateAsync(long id, UpdateBankRequest data, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync(id, data, cancellationToken);
        }

        public virtual async Task<SBBank> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync(id, cancellationToken);
        }


        public virtual async Task<SBBankAccount> GetAccountAsync(long parentId, long id, GetBankAccountRequest request, CancellationToken cancellationToken = default)
        {
            return await GetChildByIdAsync<GetBankAccountRequest, SBBankAccount>(parentId, AccountsPath, id, request, cancellationToken);
        }

        public virtual async Task<SBBankAccount> UpdateAccountAsync(long parentId, long id, UpdateBankAccountRequest data, CancellationToken cancellationToken = default)
        {
            return await UpdateChildAsync<UpdateBankAccountRequest, SBBankAccount>(parentId, AccountsPath, id, data, cancellationToken);
        }

        public virtual async Task<SBBankAccount> CreateAccountAsync(long parentId, CreateBankAccountRequest data, CancellationToken cancellationToken = default)
        {
            return await CreateChildAsync<CreateBankAccountRequest, SBBankAccount>(parentId, AccountsPath, data, cancellationToken);
        }

    }
}
