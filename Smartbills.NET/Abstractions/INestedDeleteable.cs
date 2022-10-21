using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface INestedDeletable<TEntity>
    {
        Task<TEntity> DeleteAsync(long parentId, long id, CancellationToken cancellationToken = default);
    }
}