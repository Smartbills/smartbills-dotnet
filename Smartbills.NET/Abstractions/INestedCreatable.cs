using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface INestedCreatable<TRequest, TResponse> where TRequest : class
    {
        Task<SmartbillsResponse<TResponse>> CreateAsync(long parentId, TRequest data = null, CancellationToken cancellationToken = default);
    }
}