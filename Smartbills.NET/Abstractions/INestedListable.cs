using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface INestedListable<TRequest, TResponse>
    {
        Task<SmartbillsResponse<TResponse>> ListAsync(long parentId, TRequest request, CancellationToken cancellationToken);
    }
}
