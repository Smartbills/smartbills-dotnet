using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface INestedDeletable<TResponse>
    {
        Task<TResponse> DeleteAsync(long parentId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }
}