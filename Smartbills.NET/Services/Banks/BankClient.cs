using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Banks;
using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services.BankAccounts;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Banks
{
    public interface IBankClient :
    ICreatable<CreateBankRequest, SBBank>,
    IRetrievable<SBBank>,
    IUpdatable<UpdateBankRequest, SBBank>,
    IDeletable<SBBank>
    {
        Task<SBBankAccount> GetAccountAsync(long parentId, long id, GetBankAccountRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBBankAccount> UpdateAccountAsync(long parentId, long id, UpdateBankAccountRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBBankAccount> CreateAccountAsync(long parentId, CreateBankAccountRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }
    public class BankClient : Service<SBBank>, IBankClient
    {

        public BankClient(ISmartbillsClient client) : base(client)
        {
        }
        public virtual async Task<SBBank> CreateAsync(CreateBankRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/banks", request, options, cancellationToken);
        }
        public virtual async Task<SBBank> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/banks/{id}", options, cancellationToken);
        }
        public virtual async Task<SBBank> UpdateAsync(long id, UpdateBankRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/banks/{id}", request, options, cancellationToken);
        }

        public virtual async Task<SBBank> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/banks/{id}", options, cancellationToken);
        }


        public virtual async Task<SBBankAccount> GetAccountAsync(long id, long accountId, GetBankAccountRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityAsync<GetBankAccountRequest, SBBankAccount>($"/v1/banks/{id}/account/{accountId}", request, options, cancellationToken);
        }

        public virtual async Task<SBBankAccount> UpdateAccountAsync(long id, long accountId, UpdateBankAccountRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<UpdateBankAccountRequest, SBBankAccount>($"/v1/banks/{id}/account/{accountId}", request, options, cancellationToken);
        }

        public virtual async Task<SBBankAccount> CreateAccountAsync(long id, CreateBankAccountRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<CreateBankAccountRequest, SBBankAccount>($"/v1/banks/{id}/account", request, options, cancellationToken);
        }

    }
}
