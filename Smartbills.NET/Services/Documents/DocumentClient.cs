using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Documents;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Documents
{
    public interface IDocumentClient :
       IRetrievable<SBDocument>,
        ICreatable<CreateDocumentRequest, SBDocument>,
        IDeletable<SBDocument>

    {
        Task<SBDocument> RenameAsyncAsync(long id, CancellationToken cancellationToken = default);
    }
    public class DocumentClient :
        ClientBase<SBDocument>,
        IDocumentClient
    {

        public DocumentClient(ISmartbillsClient client) : base(client) { }


        public async Task<SBDocument> CreateAsync(CreateDocumentRequest request, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/documents", request, cancellationToken);
        }
        public async Task<SBDocument> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/documents/{id}", cancellationToken);
        }

        public async Task<SBDocument> RenameAsyncAsync(long id, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/documents/{id}/rename", cancellationToken);
        }

        public async Task<SBDocument> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/documents/{id}", cancellationToken);
        }
    }
}
