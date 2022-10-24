using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface INestedCreatable<TRequest, TResposne> where TRequest : class
    {
        Task<TResposne> CreateAsync(long parentId, TRequest data = null, CancellationToken cancellationToken = default);
    }
}