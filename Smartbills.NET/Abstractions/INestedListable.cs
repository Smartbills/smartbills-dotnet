using Smartbills.NET.Entities;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface INestedListable<TRequest, TResponse>
    {
        Task<SBList<TResponse>> ListAsync(long parentId, TRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }
}
