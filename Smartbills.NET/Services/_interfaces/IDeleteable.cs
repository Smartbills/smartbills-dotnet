using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface IDeletable<TEntity, TRequest>

    {
        Task<TEntity> DeleteAsync(long id,  CancellationToken cancellationToken = default);
    }
}