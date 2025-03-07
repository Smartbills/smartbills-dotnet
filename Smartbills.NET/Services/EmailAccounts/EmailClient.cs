using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.EmailAccounts;
using Smartbills.NET.Infrastructure;

using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.EmailAccounts
{
    public interface IEmailAccountClient :
        ICreatable<EmailAccountImapCreateRequest, SBEmailAccount>,
        IRetrievableById<SBEmailAccount>,
        IUpdatable<EmailAccountImapUpdateRequest, SBEmailAccount>,
        IDeletable<SBEmailAccount>,
        IListable<EmailAccountListRequest, SBEmailAccount>
    {
    }

    public class EmailClient : Service<SBEmailAccount>, IEmailAccountClient
    {
        public EmailClient(ISmartbillsClient client) : base(client) { }

        public async Task<SBEmailAccount> CreateAsync(EmailAccountImapCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/emails/accounts", request, options, cancellationToken);
        }

        public async Task<SBEmailAccount> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/emails/accounts/{id}", options, cancellationToken);
        }

        public async Task<SBEmailAccount> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/emails/accounts/{id}", options, cancellationToken);
        }

        public async Task<SBList<SBEmailAccount>> ListAsync(EmailAccountListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/emails/accounts", request, options, cancellationToken);
        }

        public async Task<SBEmailAccount> UpdateAsync(long id, EmailAccountImapUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/emails/accounts/{id}", request, options, cancellationToken);
        }
    }
}