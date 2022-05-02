using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface ICreateable<TEntity, TRequest>

    {
        Task<SmartbillsResponse<TEntity>> CreateAsync(TRequest request, RequestOptions options = null, CancellationToken cancellationToken = default);
    }
}