using Smartbills.Client;
using Smartbills.Client.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface IReceiptItemClient : 
        INestedRetrievable<SBReceiptItem, GetReceiptItemRequest>,
        INestedDeleteable<SBReceiptItem, DeleteReceiptItemRequest>,
        INestedUpdateble<SBReceiptItem, UpdateReceiptItemRequest>,
        INestedCreateable<SBReceiptItem, CreateReceiptItemRequest>
        { }
    public class ReceiptItemClient : ServiceNested<SBReceiptItem>, IReceiptItemClient
    {
        public ReceiptItemClient(ISmartbillsClient client) : base(client)
        {
        }

        public override string BasePath => "receipt-items";

        public override string NestedPath => "receipts/${PARENT_ID}/items";

        public async Task<SmartbillsResponse<SBReceiptItem>> CreateAsync(long parentId, CreateReceiptItemRequest createRequest, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateNestedEntityAsync(parentId, createRequest, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBReceiptItem>> DeleteAsync(long parentId, long id, DeleteReceiptItemRequest request, RequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.DeleteNestedEntityAsync(parentId, id, request, options, cancellationToken);

        }

        public async Task<SmartbillsResponse<SBReceiptItem>> GetAsync(long parentId, long id, GetReceiptItemRequest request, RequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.GetNestedEntityAsync(parentId, id, request, options, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBReceiptItem>> UpdateAsync(long parentId, long id, UpdateReceiptItemRequest createRequest, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateNestedEntityAsync(parentId, id, createRequest, requestOptions, cancellationToken);
        }
    }
}
