using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface ICreatable<TRequest, TEntity>
    {
        Task<TEntity> CreateAsync(TRequest request, CancellationToken cancellationToken = default);
    }
}