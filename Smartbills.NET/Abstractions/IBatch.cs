using Smartbills.NET.Entities;
using Smartbills.NET.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface IBatchCreate<T, TResponse> 
    {
        Task<List<TResponse>> BatchCreateAsync(List<T> request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }
    public interface IBatchUpdate<T, TResponse>
    {
        Task<List<TResponse>> BatchUpdateAsync(List<T> request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }
}
