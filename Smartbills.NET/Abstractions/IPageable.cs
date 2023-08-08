using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface IPageable<TRequest, TResponse> where TRequest : PaginationRequestBase
    {
        Task<TResponse> PaginateAsync(long id, TRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);

    }
}
