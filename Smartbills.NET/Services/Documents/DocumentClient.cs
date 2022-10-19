using Smartbills.NET.Entities.Documents;
using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services._base;
using Smartbills.NET.Services._interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Documents
{
    public interface IDocumentClient :
       IRetrievable<SBDocument>
    {
    }
    public class DocumentClient :
        ClientBase<SBDocument>,
        IDocumentClient

    {
        public override string BasePath => "documents";

        public DocumentClient(ISmartbillsClient client) : base(client) { }


        public async Task<SBDocument> CreateAsync(CreateDocumentRequest data, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync(data, cancellationToken);
        }
        public async Task<SBDocument> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync(id, cancellationToken);
        }

        public async Task<SBDocument> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync(id, cancellationToken);
        }
    }
}
