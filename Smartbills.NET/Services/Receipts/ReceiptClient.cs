using RestSharp;
using Smarbtills.NET.Services;
using Smartbills.Client.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{

    public interface IReceiptClient : ICreatable<Receipt, CreateReceiptRequest>,
    IRetrievable<Receipt, GetReceiptRequest>,
        IUpdatable<Receipt, UpdateReceiptRequest>,
        IDeletable<Receipt, DeleteReceiptRequest>
    {

    }
    public class ReceiptClient : Service<Receipt>, IReceiptClient

    {
        public override string BasePath => "receipts";
        private string ReceiptItemPath = "items";

        public ReceiptClient(SmartbillsClient client) : base(client) { }


        public async Task<Receipt> CreateAsync(CreateReceiptRequest options, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(options, cancellationToken);
        }
        public async Task<Receipt> GetAsync(long id, GetReceiptRequest request = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityAsync(id, request, cancellationToken);
        }
        public async Task<Receipt> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync(id, cancellationToken);
        }

        public async Task<Receipt> UpdateAsync(long id, UpdateReceiptRequest options, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, options, cancellationToken);
        }

        public async Task<SBReceiptItem> CreateAsync(long parentId, CreateReceiptItemRequest data, CancellationToken cancellationToken = default)
        {
            return await base.CreateChildAsync<CreateReceiptItemRequest, SBReceiptItem>(parentId, this.ReceiptItemPath, data, cancellationToken);
        }

        public async Task<SBReceiptItem> DeleteAsync(long parentId, long id, CancellationToken cancellationToken = default)
        {
            return await base.DeleteChildAsync<SBReceiptItem>(parentId, this.ReceiptItemPath, id, cancellationToken);

        }

        public async Task<SBReceiptItem> GetAsync(long parentId, long id, GetReceiptItemRequest data = null, CancellationToken cancellationToken = default)
        {
            return await base.GetChildAsync<GetReceiptItemRequest, SBReceiptItem>(parentId, this.ReceiptItemPath, id, data, cancellationToken);
        }

        public async Task<SBReceiptItem> UpdateAsync(long parentId, long id, UpdateReceiptItemRequest data, CancellationToken cancellationToken = default)
        {
            return await base.UpdateChildAsync<UpdateReceiptItemRequest, SBReceiptItem>(parentId, this.ReceiptItemPath, id, data, cancellationToken);
        }
        public async Task<SmartbillsResponse<Receipt>> DeleteAsync(long id, DeleteReceiptRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<Receipt>> UpdateAsync(long id, UpdateReceiptRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
