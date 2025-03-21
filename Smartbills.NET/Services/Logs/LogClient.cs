using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Logs
{
    public interface ILogClient :
        IRetrievableById<SBLog>,
        IListable<LogListRequest, SBLog>
    {
    }

    public class LogClient : Service<SBLog>, ILogClient
    {
        public LogClient(ISmartbillsClient client) : base(client) { }

        public async Task<SBLog> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync<SBLog>($"/v1/logs/{id}", null, options, cancellationToken);
        }

        public async Task<SBList<SBLog>> ListAsync(LogListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/logs", request, options, cancellationToken);
        }


    }
}