using Smarbtills.NET.Services;
using Smartbills.NET.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services
{
    public interface IDocumentClient :
       IRetrievable<SBDocument, GetDocumentRequest>
    {
    }
    public class DocumentClient :
        Service<SBDocument>,
        IDocumentClient

    {
        public override string BasePath => "documents";

        public DocumentClient(ISBClient client) : base(client) { }


        public async Task<SBDocument> CreateAsync(CreateDocumentRequest data, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(data, cancellationToken);
        }
        public async Task<SBDocument> GetAsync(long id, GetDocumentRequest data = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync(id, data, cancellationToken);
        }

        public async Task<SBDocument> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync(id, cancellationToken);
        }
    }
}
