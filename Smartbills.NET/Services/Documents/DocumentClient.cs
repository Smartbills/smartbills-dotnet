using Smartbills.NET.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services
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
            return await base.CreateEntityAsync(data, cancellationToken);
        }
        public async Task<SBDocument> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync(id,  cancellationToken);
        }

        public async Task<SBDocument> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync(id, cancellationToken);
        }
    }
}
