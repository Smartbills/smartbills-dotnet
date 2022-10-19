using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services._interfaces
{
    public interface INestedCreateable<TEntity, TRequest> where TRequest : class
    {
        Task<TEntity> CreateAsync(long parentId, string path, TRequest data = null, CancellationToken cancellationToken = default);
    }
}