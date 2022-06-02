using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface INestedUpdateble<TEntity, TRequest> where TRequest : class
    {
        Task<TEntity> UpdateAsync(long parentId, long id, TRequest data, CancellationToken cancellationToken = default);
    }
}