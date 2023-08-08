using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface IRetrievable<TResponse>
    {
        Task<TResponse> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }

    public interface IRetrievable<TRequest, TResponse>
    {
        Task<TResponse> GetByIdAsync(long id, TRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }
}