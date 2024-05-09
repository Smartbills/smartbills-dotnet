using Smartbills.NET.Entities;
using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services.Batches;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Abstractions
{
    public interface IBatchCreate<T, TResponse> 
    {
        Task<List<BatchResponse<TResponse>>> BatchCreateAsync(T request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }
    public interface IBatchUpdate<T, TResponse>
    {
        Task<List<BatchResponse<TResponse>>> BatchUpdateAsync(T request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }
}
