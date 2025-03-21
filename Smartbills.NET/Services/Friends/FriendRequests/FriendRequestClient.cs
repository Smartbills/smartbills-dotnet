using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Friends.FriendRequests
{
    public interface IFriendRequestClient :
        IRetrievableById<SBFriendRequest>,
        IDeletable<SBFriendRequest>,
        IListable<FriendRequestListRequest, SBFriendRequest>
    {
    }

    public class FriendRequestClient : Service<SBFriendRequest>, IFriendRequestClient
    {
        public FriendRequestClient(ISmartbillsClient client) : base(client) { }

        public async Task<SBFriendRequest> CreateAsync(FriendRequestCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/friend_requests", request, options, cancellationToken);
        }

        public async Task<SBFriendRequest> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/friend_requests/{id}", options, cancellationToken);
        }

        public async Task<SBFriendRequest> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/friend_requests/{id}", options, cancellationToken);
        }

        public async Task<SBList<SBFriendRequest>> ListAsync(FriendRequestListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/friend_requests", request, options, cancellationToken);
        }

    }
}
