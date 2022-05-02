using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface INestedDeleteable<TEntity, TRequest>

    {
        Task<SmartbillsResponse<TEntity>> DeleteAsync(long parentId, long id, TRequest request, RequestOptions options = null, CancellationToken cancellationToken = default);
    }
}