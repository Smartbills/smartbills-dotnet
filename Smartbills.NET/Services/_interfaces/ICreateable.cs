using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services
{
    public interface ICreatable<TEntity, TRequest>

    {
        Task<TEntity> CreateAsync(TRequest request, CancellationToken cancellationToken = default);
    }
}