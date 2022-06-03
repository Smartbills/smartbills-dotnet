using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services
{
    public interface IDeletable<TEntity, TRequest>

    {
        Task<TEntity> DeleteAsync(long id, CancellationToken cancellationToken = default);
    }
}