using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Banks;
using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services.BankAccounts;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Banks
{
    public interface IBankClient :
    ICreatable<CreateBankRequest,SBBank>,
    IRetrievable<SBBank>,
    IUpdatable<UpdateBankRequest,SBBank>,
    IDeletable<SBBank>
    {
        Task<SBBankAccount> GetAccountAsync(long parentId, long id, GetBankAccountRequest request, CancellationToken cancellationToken = default);
        Task<SBBankAccount> UpdateAccountAsync(long parentId, long id, UpdateBankAccountRequest request, CancellationToken cancellationToken = default);
        Task<SBBankAccount> CreateAccountAsync(long parentId, CreateBankAccountRequest request, CancellationToken cancellationToken = default);
    }
    public class BankClient : ClientBase<SBBank>, IBankClient
    {
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

        public virtual async Task<SBBank> CreateAsync(CreateBankRequest request, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/banks",request, cancellationToken);
        }
        public virtual async Task<SBBank> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/banks/{id}", cancellationToken);
        }
        public virtual async Task<SBBank> UpdateAsync(long id, UpdateBankRequest request, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/banks/{id}", request, cancellationToken);
        }

        public virtual async Task<SBBank> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/banks/{id}", cancellationToken);
        }


        public virtual async Task<SBBankAccount> GetAccountAsync(long id, long accountId, GetBankAccountRequest request, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync<GetBankAccountRequest, SBBankAccount>($"/v1/banks/{id}/account/{accountId}", request, cancellationToken);
        }

        public virtual async Task<SBBankAccount> UpdateAccountAsync(long id, long accountId, UpdateBankAccountRequest request, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<UpdateBankAccountRequest, SBBankAccount>($"/v1/banks/{id}/account/{accountId}", request, cancellationToken);
        }

        public virtual async Task<SBBankAccount> CreateAccountAsync(long id, CreateBankAccountRequest request, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<CreateBankAccountRequest, SBBankAccount>($"/v1/banks/{id}/account", request, cancellationToken);
        }

    }
}
