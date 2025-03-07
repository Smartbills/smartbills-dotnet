using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Friends
{
    public interface IFriendClient :
        IRetrievableById<SBFriend>,
        IDeletable<SBFriend>,
        IListable<FriendListRequest, SBFriend>
    {
    }

    public class FriendClient : Service<SBFriend>, IFriendClient
    {
        public FriendClient(ISmartbillsClient client) : base(client) { }

        public async Task<SBFriend> CreateAsync(FriendCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/friends", request, options, cancellationToken);
        }

        public async Task<SBFriend> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/friends/{id}", options, cancellationToken);
        }

        public async Task<SBFriend> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/friends/{id}", options, cancellationToken);
        }

        public async Task<SBList<SBFriend>> ListAsync(FriendListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/friends", request, options, cancellationToken);
        }


        public async Task<SBFriend> CreateFriendAsync(FriendCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<FriendCreateRequest, SBFriend>("/v1/friends", request, options, cancellationToken);
        }

        public async Task<SBFriend> DeleteFriendAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync<SBFriend>($"/v1/friends/{id}", options, cancellationToken);
        }

        public async Task<SBFriend> GetFriendAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync<SBFriend>($"/v1/friends/{id}", null, options, cancellationToken);
        }
    }
}