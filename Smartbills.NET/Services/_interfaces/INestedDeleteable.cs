using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface INestedDeleteable<TEntity>
    {
        Task<TEntity> DeleteAsync(long parentId, string path, long id, CancellationToken cancellationToken = default);
    }
}