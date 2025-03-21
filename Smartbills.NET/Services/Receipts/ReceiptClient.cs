using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Receipts;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Smartbills.NET.Entities.Receipts.LineItems;
using Smartbills.NET.Services.Receipts.LineItems;

namespace Smartbills.NET.Services.Receipts
{

    public interface IReceiptClient :
        ICreatable<ReceiptCreateRequest, SBReceipt>,
        IRetrievableById<SBReceipt>,
        IUpdatable<ReceiptUpdateRequest, SBReceipt>,
        IDeletable<SBReceipt>,
        IListable<ReceiptListRequest, SBReceipt>,
        IBatchCreate<ReceiptCreateRequest, SBReceipt>,
        IBatchUpdate<ReceiptBatchItemUpdateRequest, SBReceipt>
    {
        Task<SBReceiptLineItem> CreateReceiptLineItemAsync(long parentId, ReceiptLineItemCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceiptLineItem> DeleteReceiptLineItemAsync(long parentId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceiptLineItem> UpdateReceiptLineItemAsync(long parentId, long id, ReceiptLineItemUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        // Task<SBReceiptLineItem> GetReceiptLineItemAsync(long parentId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);

    }
    public class ReceiptClient : Service<SBReceipt>, IReceiptClient

    {
        private readonly IReceiptLineItemClient _receiptLineItemClient;
        public ReceiptClient(ISmartbillsClient client, IReceiptLineItemClient receiptLineItemClient) : base(client)
        {
            _receiptLineItemClient = receiptLineItemClient;
        }

        public async Task<SBReceipt> CreateAsync(ReceiptCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/receipts", request, options, cancellationToken);
        }
        public async Task<SBReceipt> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/receipts/{id}", options, cancellationToken);
        }
        public async Task<SBReceipt> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/receipts/{id}", options, cancellationToken);
        }

        public async Task<SBList<SBReceipt>> ListAsync(ReceiptListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/receipts", request, options, cancellationToken);
        }

        public async Task<SBReceipt> UpdateAsync(long id, ReceiptUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/receipts/{id}", request, options, cancellationToken);
        }

        public async Task<SBReceiptLineItem> CreateReceiptLineItemAsync(long parentId, ReceiptLineItemCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<ReceiptLineItemCreateRequest, SBReceiptLineItem>($"/v1/receipts/{parentId}/items", request, options, cancellationToken);
        }

        public async Task<SBReceiptLineItem> DeleteReceiptLineItemAsync(long parentId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync<SBReceiptLineItem>($"/v1/receipts/{parentId}/items/{id}", options, cancellationToken);
        }

        // public async Task<SBReceiptLineItem> GetReceiptLineItemAsync(long parentId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        // {
        //     return await _receiptLineItemClient.GetByIdAsync(parentId, id, options, cancellationToken);
        // }

        public async Task<SBReceiptLineItem> UpdateReceiptLineItemAsync(long parentId, long id, ReceiptLineItemUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<ReceiptLineItemUpdateRequest, SBReceiptLineItem>($"/v1/receipts/{parentId}/items/{id}", request, options, cancellationToken);
        }

        public async Task<List<SBReceipt>> CreateBulkJob(ReceiptBulkJobCreateRequest request, SBRequestOptions options)
        {
            return await CreateEntityAsync<ReceiptBulkJobCreateRequest, List<SBReceipt>>("/v1/receipts/bulk", request, options);
        }

        //public async Task<SBReceipt> UploadToBulkJob(long id, ReceiptBatchUpsertRequest request, SBRequestOptions options)
        //{
        //    return await CreateEntityAsync($"/v1/receipts/bulk/{id}", request, options);
        //}

        //public async Task<SBReceipt> CompleteBulkJob(long id, SBRequestOptions options) {
        //    return await UpdateEntityAsync<>($"/v1/receipts/bulk/{id}/complete", null, options);
        //}

        public async Task<List<SBReceipt>> BatchCreateAsync(List<ReceiptCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync<List<ReceiptCreateRequest>, List<SBReceipt>>("/v1/receipts/batch", request, options, cancellationToken);
        }

        public async Task<List<SBReceipt>> BatchUpdateAsync(List<ReceiptBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync<List<ReceiptBatchItemUpdateRequest>, List<SBReceipt>>("/v1/receipts/batch", request, options, cancellationToken);
        }

        public async Task<SBReceipt> CreatePaymentAsync(long receiptId, ReceiptCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/receipts/{receiptId}/", request, options, cancellationToken);
        }
        public async Task<SBReceipt> GetByIdPaymentAsync(long receiptId, long paymentId, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/receipts/{receiptId}/payments/{paymentId}", options, cancellationToken);
        }
        public async Task<SBReceipt> DeletePaymentAsync(long receiptId, long paymentId, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/receipts/{receiptId}/payments/{paymentId}", options, cancellationToken);
        }

        public async Task<SBList<SBReceipt>> ListAsync(long receiptId, ListReceiptsRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/receipts/{receiptId}/payments", request, options, cancellationToken);
        }

        public async Task<SBReceipt> UpdatePaymentAsync(long receiptId, long paymentId, ReceiptUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/receipts/{receiptId}/payments/{paymentId}", request, options, cancellationToken);
        }

    }
}
