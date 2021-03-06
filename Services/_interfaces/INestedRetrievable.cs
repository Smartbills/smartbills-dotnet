using System;
using System.Threading;
using System.Threading.Tasks;
using Smartbills.Client.Entities;

namespace Smartbills.Client.Services
{
    public interface INestedRetrievable<TEntity, TRequest>
    
    {
        Task<SmartbillsResponse<TEntity>> GetAsync(Guid parentId, Guid id, TRequest createRequest, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}