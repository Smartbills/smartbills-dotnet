using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Reviews;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Reviews
{
    public interface IReviewClient :
        ICreatable<ReviewCreateRequest, SBReview>,
        IRetrievableById<SBReview>,
        IUpdatable<ReviewUpdateRequest, SBReview>,
        IDeletable<SBReview>,
        IListable<ReviewListRequest, SBReview>
    {
    }

    public class ReviewClient : Service<SBReview>, IReviewClient
    {
        public ReviewClient(ISmartbillsClient client) : base(client) { }

        public async Task<SBReview> CreateAsync(ReviewCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/reviews", request, options, cancellationToken);
        }

        public async Task<SBReview> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/reviews/{id}", options, cancellationToken);
        }

        public async Task<SBReview> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/reviews/{id}", options, cancellationToken);
        }

        public async Task<SBList<SBReview>> ListAsync(ReviewListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/reviews", request, options, cancellationToken);
        }

        public async Task<SBReview> UpdateAsync(long id, ReviewUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/reviews/{id}", request, options, cancellationToken);
        }
    }
}