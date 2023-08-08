using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
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
        IListable<ListReceiptsRequest, PaginatedResponse<SBReceipt>>
    {
        Task<SBReceiptItem> CreateReceiptItemAsync(long parentId, CreateReceiptItemRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceiptItem> DeleteReceiptItemAsync(long parentId, long id,SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceiptItem> UpdateReceiptItemAsync(long parentId, long id, UpdateReceiptItemRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceiptItem> GetReceiptItemAsync(long parentId, long id, GetReceiptItemRequest request = null, SBRequestOptions options = null, CancellationToken cancellationToken = default);

    }
    public class ReceiptClient : Service<SBReceipt>, IReceiptClient

    {
        public ReceiptClient(ISmartbillsClient client) : base(client) { }

        public async Task<SBReceipt> CreateAsync(CreateReceiptRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/receipts", request, options, cancellationToken);
        }
        public async Task<SBReceipt> GetByIdAsync(long id,SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/receipts/{id}",options, cancellationToken);
        }
        public async Task<SBReceipt> DeleteAsync(long id,SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/receipts/{id}",options, cancellationToken);
        }

        public async Task<PaginatedResponse<SBReceipt>> ListAsync(ListReceiptsRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await ListAsync(request, options, cancellationToken);
        }

        public async Task<SBReceipt> UpdateAsync(long id, UpdateReceiptRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/receipts/{id}", request, options, cancellationToken);
        }

        public async Task<SBReceiptItem> CreateReceiptItemAsync(long parentId, CreateReceiptItemRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<CreateReceiptItemRequest, SBReceiptItem>($"/v1/receipts/{parentId}/items", request, options, cancellationToken);
        }

        public async Task<SBReceiptItem> DeleteReceiptItemAsync(long parentId, long id,SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync<SBReceiptItem>($"/v1/receipts/{parentId}/items/{id}",options, cancellationToken);
        }

        public async Task<SBReceiptItem> GetReceiptItemAsync(long parentId, long id, GetReceiptItemRequest request = null, SBRequestOptions options= null, CancellationToken cancellationToken = default)
        {
            return await GetEntityAsync<GetReceiptItemRequest, SBReceiptItem>($"/v1/receipts/{parentId}/items/{id}", request, options, cancellationToken);
        }

        public async Task<SBReceiptItem> UpdateReceiptItemAsync(long parentId, long id, UpdateReceiptItemRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<UpdateReceiptItemRequest, SBReceiptItem>($"/v1/receipts/{parentId}/items/{id}", request, options, cancellationToken);
        }

    }
}
