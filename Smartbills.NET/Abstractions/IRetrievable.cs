using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface IRetrievableById<TResponse>
    {
        Task<TResponse> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }

    public interface IRetrievableById<TRequest, TResponse>
    {
        Task<TResponse> GetByIdAsync(long id, TRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }
    public interface IRetrievable<TRequest, TResponse> where TRequest : ListRequest
    {
        Task<TResponse[]> GetAsync(TRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }
}