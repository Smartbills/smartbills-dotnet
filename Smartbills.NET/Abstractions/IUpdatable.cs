using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface IUpdatable<TRequest, TResponse> where TRequest : class
    {
        Task<SmartbillsResponse<TResponse>> UpdateAsync(long id, TRequest request, CancellationToken cancellationToken = default);
    }
}