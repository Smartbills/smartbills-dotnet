using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services._interfaces
{
    public interface INestedRetrievable<TEntity, TRequest> where TRequest : class

    {
        Task<TEntity> GetAsync(long parentId, long id, TRequest request, CancellationToken cancellationToken = default);
    }
}