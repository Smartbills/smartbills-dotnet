using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services._interfaces
{
    public interface INestedDeleteable<TEntity>
    {
        Task<TEntity> DeleteAsync(long parentId, string path, long id, CancellationToken cancellationToken = default);
    }
}