using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface INestedDeletable<TResponse>
    {
        Task<SmartbillsResponse<TResponse>> DeleteAsync(long parentId, long id, CancellationToken cancellationToken = default);
    }
}