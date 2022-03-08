using System;
using System.Threading;
using System.Threading.Tasks;
using Smartbills.Client.Entities;

namespace Smartbills.Client.Services
{
    public interface ISingletonRetrievable<TEntity, TRequest>
    
    {
        Task<SmartbillsResponse<TEntity>> GetAsync(TRequest options, CancellationToken cancellationToken = default);
    }
}