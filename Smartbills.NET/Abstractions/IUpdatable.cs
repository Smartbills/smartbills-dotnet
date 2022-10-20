using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface IUpdatable<TEntity, TRequest> where TRequest : class
    {
        Task<TEntity> UpdateAsync(long id, TRequest request, CancellationToken cancellationToken = default);
    }
}