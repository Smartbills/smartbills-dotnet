using RestSharp;
using Smartbills.NET.Entities.Files;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Files
{
    public interface IFileClient
    {
        Task<SBFile> UploadFileAsync(UploadFileRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBFile> DownloadFileAsync(DownloadFileRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBFile> DeleteFileAsync(DeleteFileRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }

    public class FileClient : Service<SBFile>, IFileClient
    {
        public FileClient(ISmartbillsClient client) : base(client, client.FileClient)
        {
        }

        public async Task<SBFile> UploadFileAsync(UploadFileRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            var restRequest = new RestRequest("files/upload") { Method = Method.Post }.AddObject(request).AddHeader("content-type", "multipart/form-data");
            return await ExecuteCustomRequestAsync<SBFile>(restRequest, options, cancellationToken);
        }

        public async Task<SBFile> DownloadFileAsync(DownloadFileRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            var restRequest = new RestRequest("files/download").AddObject(request).AddHeader("content-type", "application/json");
            return await ExecuteCustomRequestAsync<SBFile>(restRequest, options, cancellationToken);
        }

        public async Task<SBFile> DeleteFileAsync(DeleteFileRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            var restRequest = new RestRequest("files/delete") { Method = Method.Delete }.AddObject(request).AddHeader("content-type", "application/json");
            return await ExecuteCustomRequestAsync<SBFile>(restRequest, options, cancellationToken);
        }
    }
}