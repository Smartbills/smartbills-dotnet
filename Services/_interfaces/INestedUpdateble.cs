using System;
using System.Threading;
using System.Threading.Tasks;
using Smartbills.Client.Entities;

namespace Smartbills.Client.Services
{
    public interface INestedUpdateble<TEntity, TRequest>
    
    {
        Task<SmartbillsResponse<TEntity>> UpdateAsync(Guid parentId, Guid id, TRequest createRequest, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}