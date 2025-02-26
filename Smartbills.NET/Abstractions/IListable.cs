using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface IListable<TRequest, TResponse> where TRequest : ListRequest
    {
        Task<TResponse> ListAsync(TRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }
}
