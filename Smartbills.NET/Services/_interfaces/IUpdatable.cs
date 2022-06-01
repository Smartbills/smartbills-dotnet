using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface IUpdatable<TEntity, TRequest> where TRequest : class
    {
        Task<TEntity> UpdateAsync(long id, TRequest request, CancellationToken cancellationToken = default);
    }
}