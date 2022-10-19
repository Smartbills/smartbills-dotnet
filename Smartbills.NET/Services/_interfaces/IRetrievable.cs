using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services._interfaces
{
    public interface IRetrievable<TEntity>
    {
        Task<TEntity> GetByIdAsync(long id, CancellationToken cancellationToken = default);
    }

    public interface IRetrievable<TEntity, TRequest>
    {
        Task<TEntity> GetByIdAsync(long id, TRequest request, CancellationToken cancellationToken = default);
    }
}