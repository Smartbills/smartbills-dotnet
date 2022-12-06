using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface INestedUpdatable<TRequest, TResponse> where TRequest : class
    {
        Task<SmartbillsResponse<TResponse>> UpdateAsync(long parentId, long id, TRequest data, CancellationToken cancellationToken = default);
    }
}