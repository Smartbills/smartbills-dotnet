using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Webhooks
{
    public interface IWebhookClient :
        ICreatable<WebhookCreateRequest, SBWebhook>,
        IRetrievableById<SBWebhook>,
        IUpdatable<WebhookUpdateRequest, SBWebhook>,
        IDeletable<SBWebhook>,
        IListable<WebhookListRequest, SBWebhook>
    {
        Task<SBWebhook> CreateWebhookAsync(WebhookCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBWebhook> DeleteWebhookAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBWebhook> UpdateWebhookAsync(long id, WebhookUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBWebhook> GetWebhookAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }

    public class WebhookClient : Service<SBWebhook>, IWebhookClient
    {
        public WebhookClient(ISmartbillsClient client) : base(client) { }

        public async Task<SBWebhook> CreateAsync(WebhookCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/webhooks", request, options, cancellationToken);
        }

        public async Task<SBWebhook> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/webhooks/{id}", options, cancellationToken);
        }

        public async Task<SBWebhook> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/webhooks/{id}", options, cancellationToken);
        }

        public async Task<SBList<SBWebhook>> ListAsync(WebhookListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/webhooks", request, options, cancellationToken);
        }

        public async Task<SBWebhook> UpdateAsync(long id, WebhookUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/webhooks/{id}", request, options, cancellationToken);
        }

        public async Task<SBWebhook> CreateWebhookAsync(WebhookCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<WebhookCreateRequest, SBWebhook>("/v1/webhooks", request, options, cancellationToken);
        }

        public async Task<SBWebhook> DeleteWebhookAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync<SBWebhook>($"/v1/webhooks/{id}", options, cancellationToken);
        }

        public async Task<SBWebhook> GetWebhookAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync<SBWebhook>($"/v1/webhooks/{id}", null, options, cancellationToken);
        }

        public async Task<SBWebhook> UpdateWebhookAsync(long id, WebhookUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<WebhookUpdateRequest, SBWebhook>($"/v1/webhooks/{id}", request, options, cancellationToken);
        }
    }
}