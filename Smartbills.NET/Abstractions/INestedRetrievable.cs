using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface INestedRetrievable<TEntity>

    {
        Task<TEntity> GetByIdAsync(long parentId, long id, CancellationToken cancellationToken = default);
    }
}