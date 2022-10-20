using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface INestedDeleteable<TEntity>
    {
        Task<TEntity> DeleteAsync(long parentId, string path, long id, CancellationToken cancellationToken = default);
    }
}