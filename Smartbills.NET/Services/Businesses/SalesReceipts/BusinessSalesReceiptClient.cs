using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Receipts;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Smartbills.NET.Entities.Receipts.LineItems;
using Smartbills.NET.Services.Receipts.LineItems;
using Smartbills.NET.Services.Receipts;

namespace Smartbills.NET.Services.businesss.Receipts
{
    public interface ISalesReceiptClient
    {
        Task<SBReceipt> CreateAsync(long businessId, ReceiptCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceipt> GetByIdAsync(long businessId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceipt> DeleteAsync(long businessId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBList<SBReceipt>> ListAsync(long businessId, ReceiptListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceipt> UpdateAsync(long businessId, long id, ReceiptUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<List<SBReceipt>> BatchCreateAsync(long businessId, List<ReceiptCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<List<SBReceipt>> BatchUpdateAsync(long businessId, List<ReceiptBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceiptLineItem> CreateReceiptLineItemAsync(long businessId, long receiptId, ReceiptLineItemCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceiptLineItem> DeleteReceiptLineItemAsync(long businessId, long receiptId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceiptLineItem> UpdateReceiptLineItemAsync(long businessId, long receiptId, long id, ReceiptLineItemUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceipt> CreatePaymentAsync(long businessId, long receiptId, ReceiptCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceipt> GetByIdPaymentAsync(long businessId, long receiptId, long paymentId, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceipt> DeletePaymentAsync(long businessId, long receiptId, long paymentId, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBList<SBReceipt>> ListPaymentsAsync(long businessId, long receiptId, ReceiptListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceipt> UpdatePaymentAsync(long businessId, long receiptId, long paymentId, ReceiptUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }

    public class SalesReceiptClient : Service<SBReceipt>, ISalesReceiptClient
    {
        private readonly IReceiptLineItemClient _receiptLineItemClient;

        public SalesReceiptClient(ISmartbillsClient client, IReceiptLineItemClient receiptLineItemClient) : base(client)
        {
            _receiptLineItemClient = receiptLineItemClient;
        }

        public async Task<SBReceipt> CreateAsync(long businessId, ReceiptCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/businesses/{businessId}/receipts", request, options, cancellationToken);
        }

        public async Task<SBReceipt> GetByIdAsync(long businessId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/businesses/{businessId}/receipts/{id}", options, cancellationToken);
        }

        public async Task<SBReceipt> DeleteAsync(long businessId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/businesses/{businessId}/receipts/{id}", options, cancellationToken);
        }

        public async Task<SBList<SBReceipt>> ListAsync(long businessId, ReceiptListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/businesses/{businessId}/receipts", request, options, cancellationToken);
        }

        public async Task<SBReceipt> UpdateAsync(long businessId, long id, ReceiptUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/businesses/{businessId}/receipts/{id}", request, options, cancellationToken);
        }

        public async Task<SBReceiptLineItem> CreateReceiptLineItemAsync(long businessId, long receiptId, ReceiptLineItemCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<ReceiptLineItemCreateRequest, SBReceiptLineItem>($"/v1/businesses/{businessId}/receipts/{receiptId}/items", request, options, cancellationToken);
        }

        public async Task<SBReceiptLineItem> DeleteReceiptLineItemAsync(long businessId, long receiptId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync<SBReceiptLineItem>($"/v1/businesses/{businessId}/receipts/{receiptId}/items/{id}", options, cancellationToken);
        }

        public async Task<SBReceiptLineItem> UpdateReceiptLineItemAsync(long businessId, long receiptId, long id, ReceiptLineItemUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<ReceiptLineItemUpdateRequest, SBReceiptLineItem>($"/v1/businesses/{businessId}/receipts/{receiptId}/items/{id}", request, options, cancellationToken);
        }

        public async Task<List<SBReceipt>> BatchCreateAsync(long businessId, List<ReceiptCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<List<ReceiptCreateRequest>, List<SBReceipt>>($"/v1/businesses/{businessId}/receipts/batch", request, options, cancellationToken);
        }

        public async Task<List<SBReceipt>> BatchUpdateAsync(long businessId, List<ReceiptBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<List<ReceiptBatchItemUpdateRequest>, List<SBReceipt>>($"/v1/businesses/{businessId}/receipts/batch", request, options, cancellationToken);
        }

        public async Task<SBReceipt> CreatePaymentAsync(long businessId, long receiptId, ReceiptCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/businesses/{businessId}/receipts/{receiptId}/payments", request, options, cancellationToken);
        }

        public async Task<SBReceipt> GetByIdPaymentAsync(long businessId, long receiptId, long paymentId, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/businesses/{businessId}/receipts/{receiptId}/payments/{paymentId}", options, cancellationToken);
        }

        public async Task<SBReceipt> DeletePaymentAsync(long businessId, long receiptId, long paymentId, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/businesses/{businessId}/receipts/{receiptId}/payments/{paymentId}", options, cancellationToken);
        }

        public async Task<SBList<SBReceipt>> ListPaymentsAsync(long businessId, long receiptId, ReceiptListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/businesses/{businessId}/receipts/{receiptId}/payments", request, options, cancellationToken);
        }

        public async Task<SBReceipt> UpdatePaymentAsync(long businessId, long receiptId, long paymentId, ReceiptUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/businesses/{businessId}/receipts/{receiptId}/payments/{paymentId}", request, options, cancellationToken);
        }
    }
}
