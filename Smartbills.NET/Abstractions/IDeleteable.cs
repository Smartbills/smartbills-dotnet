using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface IDeletable<TResponse>

    {
        Task<TResponse> DeleteAsync(long id, CancellationToken cancellationToken = default);
    }
}