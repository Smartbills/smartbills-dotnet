using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Smartbills.Client.Entities;

namespace Smartbills.Client.Services
{
    public interface IRetrievable<TEntity, TRequest>
    
    {
        Task<SmartbillsResponse<TEntity>> GetAsync(Guid id, TRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default);
    }
}