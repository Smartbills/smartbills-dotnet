using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface INestedUpdateble<TEntity, TRequest>

    {
        Task<SmartbillsResponse<TEntity>> UpdateAsync(long parentId, long id, TRequest createRequest, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}