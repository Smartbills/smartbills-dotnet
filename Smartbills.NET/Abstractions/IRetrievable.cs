using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface IRetrievable<TResponse>
    {
        Task<SmartbillsResponse<TResponse>> GetByIdAsync(long id, CancellationToken cancellationToken = default);
    }

    public interface IRetrievable<TRequest, TResponse>
    {
        Task<SmartbillsResponse<TResponse>> GetByIdAsync(long id, TRequest request, CancellationToken cancellationToken = default);
    }
}