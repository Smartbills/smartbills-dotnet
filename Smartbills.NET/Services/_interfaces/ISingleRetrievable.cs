using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface ISingletonRetrievable<TEntity, TRequest>
    {
        Task<TEntity> GetAsync(TRequest options, CancellationToken cancellationToken = default);
    }
}