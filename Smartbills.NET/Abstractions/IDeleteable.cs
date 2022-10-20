using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface IDeletable<TEntity>

    {
        Task<TEntity> DeleteAsync(long id, CancellationToken cancellationToken = default);
    }
}