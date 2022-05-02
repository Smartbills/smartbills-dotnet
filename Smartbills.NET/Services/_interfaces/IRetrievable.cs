using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface IRetrievable<TEntity, TRequest>

    {
        Task<SmartbillsResponse<TEntity>> GetAsync(long id, TRequest request, RequestOptions options = null, CancellationToken cancellationToken = default);
    }
}