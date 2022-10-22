using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.ReceiptItems;
using Smartbills.NET.Entities.Receipts;
using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services.ReceiptItems;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Receipts
{

    public interface IReceiptClient :
        ICreatable<CreateReceiptRequest, SBReceipt>,
        IRetrievable<SBReceipt>,
        IUpdatable<UpdateReceiptRequest, SBReceipt>,
        IDeletable<SBReceipt>,
        IListable<ListReceiptsRequest, SBReceipt>
    {

    }
    public class ReceiptClient : ClientBase<SBReceipt>, IReceiptClient

    {
        public override string BasePath => "receipts";
        private readonly string ReceiptItemPath = "items";

        public ReceiptClient(ISmartbillsClient client) : base(client) { }


        public async Task<SBReceipt> CreateAsync(CreateReceiptRequest options, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync(options, cancellationToken);
        }
        public async Task<SBReceipt> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync(id, cancellationToken);
        }
        public async Task<SBReceipt> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync(id, cancellationToken);
        }

        public async Task<SBReceipt> UpdateAsync(long id, UpdateReceiptRequest options, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync(id, options, cancellationToken);
        }

        public async Task<SBReceiptItem> CreateAsync(long parentId, CreateReceiptItemRequest data, CancellationToken cancellationToken = default)
        {
            return await CreateChildAsync<CreateReceiptItemRequest, SBReceiptItem>(parentId, ReceiptItemPath, data, cancellationToken);
        }

        public async Task<SBReceiptItem> DeleteAsync(long parentId, long id, CancellationToken cancellationToken = default)
        {
            return await DeleteChildAsync<SBReceiptItem>(parentId, ReceiptItemPath, id, cancellationToken);

        }

        public async Task<SBReceiptItem> GetAsync(long parentId, long id, GetReceiptItemRequest data = null, CancellationToken cancellationToken = default)
        {
            return await GetChildByIdAsync<GetReceiptItemRequest, SBReceiptItem>(parentId, ReceiptItemPath, id, data, cancellationToken);
        }

        public async Task<SBReceiptItem> UpdateAsync(long parentId, long id, UpdateReceiptItemRequest data, CancellationToken cancellationToken = default)
        {
            return await UpdateChildAsync<UpdateReceiptItemRequest, SBReceiptItem>(parentId, ReceiptItemPath, id, data, cancellationToken);
        }

        public async Task<SBReceipt> ListAsync(ListReceiptsRequest request, CancellationToken cancellationToken = default)
        {
            return await ListAsync(request, cancellationToken);
        }
    }
}
