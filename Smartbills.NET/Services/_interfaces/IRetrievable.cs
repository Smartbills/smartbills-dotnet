using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface IRetrievable<TEntity, TRequest>

    {
        Task<SmartbillsResponse<TEntity>> GetAsync(Guid id, TRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}