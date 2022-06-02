
using RestSharp;
using Smarbtills.NET.Services;
using Smartbills.Client.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
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

        public DocumentClient(SmartbillsClient client) : base(client) { }


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
