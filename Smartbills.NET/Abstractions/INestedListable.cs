using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface INestedListable<TRequest, TResponse>
    {
        Task<TResponse> ListAsync(long parentId, TRequest request, CancellationToken cancellationToken);
    }
}
