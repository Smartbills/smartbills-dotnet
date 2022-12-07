using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface ICreatable<TRequest, TResponse>
    {
        Task<TResponse> CreateAsync(TRequest request, CancellationToken cancellationToken = default);
    }
}