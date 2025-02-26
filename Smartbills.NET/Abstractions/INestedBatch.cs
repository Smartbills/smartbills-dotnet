using Smartbills.NET.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Smartbills.NET.Abstractions
{
    public interface INestedBatchCreate<T, TResponse>
    {
        Task<List<TResponse>> BatchCreateAsync(long parentId, List<T> request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }
    public interface INestedBatchUpdate<T, TResponse>
    {
        Task<List<TResponse>> BatchUpdateAsync(long parentId, List<T> request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }
}
