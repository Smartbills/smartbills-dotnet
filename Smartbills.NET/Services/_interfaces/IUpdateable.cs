using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface IUpdateable<TEntity, TRequest>

    {
        Task<SmartbillsResponse<TEntity>> UpdateAsync(Guid id, TRequest updateRequest, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}