using System;
using System.Threading;
using System.Threading.Tasks;
using Smartbills.Client.Entities;

namespace Smartbills.Client.Services
{
    public interface IDeleteable<TEntity, TRequest>
    
    {
        Task<SmartbillsResponse<TEntity>> DeleteAsync(Guid id, TRequest createRequest, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}