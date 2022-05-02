using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface INestedRetrievable<TEntity, TRequest>

    {
        Task<SmartbillsResponse<TEntity>> GetAsync(long parentId, long id, TRequest createRequest, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}