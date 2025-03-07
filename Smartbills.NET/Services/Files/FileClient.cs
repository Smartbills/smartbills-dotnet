using RestSharp;
using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Files;
using Smartbills.NET.Infrastructure;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Files
{
    public interface IFileClient : IRetrievableById<SBFile>
    {
        Task<Stream> DownloadFileAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }

    public class FileClient : Service<SBFile>, IFileClient
    {
        public FileClient(ISmartbillsClient client) : base(client, client.ApiClient)
        {
        }

        public async Task<Stream> DownloadFileAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DownloadAsync($"/v1/files/{id}/download", options, cancellationToken);
        }

        public async Task<SBFile> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/files/{id}", options, cancellationToken);
        }
    }
}