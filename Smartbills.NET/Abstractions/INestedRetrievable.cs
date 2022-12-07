using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface INestedRetrievable<TResponse>

    {
        Task<TResponse> GetByIdAsync(long parentId, long id, CancellationToken cancellationToken = default);
    }
}