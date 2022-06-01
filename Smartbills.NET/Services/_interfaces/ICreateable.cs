using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface ICreatable<TEntity, TRequest>

    {
        Task<TEntity> CreateAsync(TRequest request,  CancellationToken cancellationToken = default);
    }
}