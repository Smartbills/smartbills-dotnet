using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface INestedCreatable<TRequest, TResponse> where TRequest : class
    {
        Task<TResponse> CreateAsync(long parentId, TRequest data = null, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }
}