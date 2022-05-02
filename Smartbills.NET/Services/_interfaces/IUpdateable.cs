using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface IUpdateable<TEntity, TRequest>

    {
        Task<SmartbillsResponse<TEntity>> UpdateAsync(long id, TRequest request, RequestOptions options = null, CancellationToken cancellationToken = default);
    }
}