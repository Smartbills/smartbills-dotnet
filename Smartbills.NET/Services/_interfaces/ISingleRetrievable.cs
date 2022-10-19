using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services._interfaces
{
    public interface ISingletonRetrievable<TEntity, TRequest>
    {
        Task<TEntity> GetAsync(TRequest options, CancellationToken cancellationToken = default);
    }
}