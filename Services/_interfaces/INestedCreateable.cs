using System;
using System.Threading;
using System.Threading.Tasks;
using Smartbills.Client.Entities;

namespace Smartbills.Client.Services
{
    public interface INestedCreateable<TEntity, TRequest>
    
    {
        Task<SmartbillsResponse<TEntity>> CreateAsync(Guid parentId, TRequest createRequest, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}