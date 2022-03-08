
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

        public DocumentClient(ISmartbillsClient client) : base(client) { }


        public async Task<SmartbillsResponse<SBDocument>> CreateAsync(CreateDocumentRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(options, requestOptions, cancellationToken);
        }
        public async Task<SmartbillsResponse<SBDocument>> GetAsync(Guid id, GetDocumentRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBDocument>> DeleteAsync(Guid id, DeleteDocumentRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
