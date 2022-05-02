using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface INestedCreateable<TEntity, TRequest>

    {
        Task<SmartbillsResponse<TEntity>> CreateAsync(long parentId, TRequest createRequest, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}