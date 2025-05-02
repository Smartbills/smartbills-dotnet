using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Webhooks;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Webhooks
{
    public interface IWebhookClient :
        ICreatable<WebhookCreateRequest, SBWebhookSubscription>,
        IRetrievableById<SBWebhookSubscription>,
        IUpdatable<WebhookUpdateRequest, SBWebhookSubscription>,
        IDeletable<SBWebhookSubscription>,
        IListable<WebhookListRequest, SBWebhookSubscription>
    {
        Task<SBWebhookSubscription> CreateWebhookAsync(WebhookCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBWebhookSubscription> DeleteWebhookAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBWebhookSubscription> UpdateWebhookAsync(long id, WebhookUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBWebhookSubscription> GetWebhookAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }

    public class WebhookClient : Service<SBWebhookSubscription>, IWebhookClient
    {
        public WebhookClient(ISmartbillsClient client) : base(client) { }

        public async Task<SBWebhookSubscription> CreateAsync(WebhookCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/webhooks", request, options, cancellationToken);
        }

        public async Task<SBWebhookSubscription> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/webhooks/{id}", options, cancellationToken);
        }

        public async Task<SBWebhookSubscription> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/webhooks/{id}", options, cancellationToken);
        }

        public async Task<SBList<SBWebhookSubscription>> ListAsync(WebhookListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/webhooks", request, options, cancellationToken);
        }

        public async Task<SBWebhookSubscription> UpdateAsync(long id, WebhookUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/webhooks/{id}", request, options, cancellationToken);
        }

        public async Task<SBWebhookSubscription> CreateWebhookAsync(WebhookCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<WebhookCreateRequest, SBWebhookSubscription>("/v1/webhooks", request, options, cancellationToken);
        }

        public async Task<SBWebhookSubscription> DeleteWebhookAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync<SBWebhookSubscription>($"/v1/webhooks/{id}", options, cancellationToken);
        }

        public async Task<SBWebhookSubscription> GetWebhookAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync<SBWebhookSubscription>($"/v1/webhooks/{id}", null, options, cancellationToken);
        }

        public async Task<SBWebhookSubscription> UpdateWebhookAsync(long id, WebhookUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<WebhookUpdateRequest, SBWebhookSubscription>($"/v1/webhooks/{id}", request, options, cancellationToken);
        }
    }
}