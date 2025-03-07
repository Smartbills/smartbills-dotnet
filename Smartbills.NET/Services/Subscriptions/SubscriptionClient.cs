using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Subscriptions;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Subscriptions
{
    public interface ISubscriptionClient :
        ICreatable<SubscriptionCreateRequest, SBSubscription>,
        IRetrievableById<SBSubscription>,
        // IUpdatable<SubscriptionUpdateRequest, SBSubscription>,
        IDeletable<SBSubscription>
    // IListable<SubscriptionListRequest, SBList<SBSubscription>>
    {
    }

    public class SubscriptionClient : Service<SBSubscription>, ISubscriptionClient
    {
        public SubscriptionClient(ISmartbillsClient client) : base(client) { }

        public async Task<SBSubscription> CreateAsync(SubscriptionCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/subscriptions", request, options, cancellationToken);
        }

        public async Task<SBSubscription> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/subscriptions/{id}", options, cancellationToken);
        }

        public async Task<SBSubscription> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/subscriptions/{id}", options, cancellationToken);
        }

        // public async Task<SBList<SBSubscription>> ListAsync(SubscriptionListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        // {
        //     return await PaginateEntityAsync($"/v1/subscriptions", request, options, cancellationToken);
        // }

        // public async Task<SBSubscription> UpdateAsync(long id, SubscriptionUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        // {
        //     return await UpdateEntityAsync($"/v1/subscriptions/{id}", request, options, cancellationToken);
        // }
    }
}