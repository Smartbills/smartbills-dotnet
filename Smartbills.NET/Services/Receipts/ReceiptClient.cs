using Org.BouncyCastle.Asn1.Ocsp;
using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Receipts;
using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services.Receipts;
using Smartbills.NET.Services.ReceiptItems;
using System;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using Smartbills.NET.Services.Customers;
using System.Collections.Generic;

namespace Smartbills.NET.Services.Receipts
{

    public interface IReceiptClient :
        ICreatable<ReceiptCreateRequest, SBReceipt>,
        IRetrievable<SBReceipt>,
        IUpdatable<ReceiptUpdateRequest, SBReceipt>,
        IDeletable<SBReceipt>,
        IListable<ListReceiptsRequest, PaginatedResponse<SBReceipt>>,
        IBatchCreate<ReceiptCreateRequest, SBReceipt>,
        IBatchUpdate<ReceiptBatchItemUpdateRequest, SBReceipt>
    {
        Task<SBReceiptItem> CreateReceiptItemAsync(long parentId, ReceiptItemCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceiptItem> DeleteReceiptItemAsync(long parentId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceiptItem> UpdateReceiptItemAsync(long parentId, long id, ReceiptItemUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceiptItem> GetReceiptItemAsync(long parentId, long id, GetReceiptItemRequest request = null, SBRequestOptions options = null, CancellationToken cancellationToken = default);

    }
    public class ReceiptClient : Service<SBReceipt>, IReceiptClient

    {
        public ReceiptClient(ISmartbillsClient client) : base(client) { }

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

        public async Task<PaginatedResponse<SBReceipt>> ListAsync(ListReceiptsRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/receipts", request, options, cancellationToken);
        }

        public async Task<SBReceipt> UpdateAsync(long id, ReceiptUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/receipts/{id}", request, options, cancellationToken);
        }

        public async Task<SBReceiptItem> CreateReceiptItemAsync(long parentId, ReceiptItemCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<ReceiptItemCreateRequest, SBReceiptItem>($"/v1/receipts/{parentId}/items", request, options, cancellationToken);
        }

        public async Task<SBReceiptItem> DeleteReceiptItemAsync(long parentId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync<SBReceiptItem>($"/v1/receipts/{parentId}/items/{id}", options, cancellationToken);
        }

        public async Task<SBReceiptItem> GetReceiptItemAsync(long parentId, long id, GetReceiptItemRequest request = null, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityAsync<GetReceiptItemRequest, SBReceiptItem>($"/v1/receipts/{parentId}/items/{id}", request, options, cancellationToken);
        }

        public async Task<SBReceiptItem> UpdateReceiptItemAsync(long parentId, long id, ReceiptItemUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<ReceiptItemUpdateRequest, SBReceiptItem>($"/v1/receipts/{parentId}/items/{id}", request, options, cancellationToken);
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

        public async Task<PaginatedResponse<SBReceipt>> ListAsync(long receiptId, ListReceiptsRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/receipts/{receiptId}/payments", request, options, cancellationToken);
        }

        public async Task<SBReceipt> UpdatePaymentAsync(long receiptId, long paymentId, ReceiptUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/receipts/{receiptId}/payments/{paymentId}", request, options, cancellationToken);
        }

    }
}
