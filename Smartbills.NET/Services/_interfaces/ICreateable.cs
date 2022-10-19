using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services._interfaces
{
    public interface ICreatable<TEntity, TRequest>

    {
        Task<TEntity> CreateAsync(TRequest request, CancellationToken cancellationToken = default);
    }
}