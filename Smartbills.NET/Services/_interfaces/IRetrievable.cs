using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services
{
    public interface IRetrievable<TEntity, TRequest> where TRequest : class
    {
        Task<TEntity> GetAsync(long id, TRequest request = null, CancellationToken cancellationToken = default);
    }
}