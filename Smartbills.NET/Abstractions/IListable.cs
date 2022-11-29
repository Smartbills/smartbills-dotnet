using Smartbills.NET.Services;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface IListable<TRequest, TEntity> where TRequest : ListRequest
    {
        Task<TEntity> ListAsync(TRequest request, CancellationToken cancellationToken = default);
    }
}
