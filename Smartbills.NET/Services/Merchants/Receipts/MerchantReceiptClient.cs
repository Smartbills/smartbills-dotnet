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

namespace Smartbills.NET.Services.Merchants.Receipts
{
    public interface IMerchantReceiptClient
    {
        Task<SBReceipt> CreateAsync(long merchantId, ReceiptCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceipt> GetByIdAsync(long merchantId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceipt> DeleteAsync(long merchantId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBList<SBReceipt>> ListAsync(long merchantId, ReceiptListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceipt> UpdateAsync(long merchantId, long id, ReceiptUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<List<SBReceipt>> BatchCreateAsync(long merchantId, List<ReceiptCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<List<SBReceipt>> BatchUpdateAsync(long merchantId, List<ReceiptBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceiptLineItem> CreateReceiptLineItemAsync(long merchantId, long receiptId, ReceiptLineItemCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceiptLineItem> DeleteReceiptLineItemAsync(long merchantId, long receiptId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceiptLineItem> UpdateReceiptLineItemAsync(long merchantId, long receiptId, long id, ReceiptLineItemUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceipt> CreatePaymentAsync(long merchantId, long receiptId, ReceiptCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceipt> GetByIdPaymentAsync(long merchantId, long receiptId, long paymentId, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceipt> DeletePaymentAsync(long merchantId, long receiptId, long paymentId, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBList<SBReceipt>> ListPaymentsAsync(long merchantId, long receiptId, ReceiptListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
        Task<SBReceipt> UpdatePaymentAsync(long merchantId, long receiptId, long paymentId, ReceiptUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default);
    }

    public class MerchantReceiptClient : Service<SBReceipt>, IMerchantReceiptClient
    {
        private readonly IReceiptLineItemClient _receiptLineItemClient;

        public MerchantReceiptClient(ISmartbillsClient client, IReceiptLineItemClient receiptLineItemClient) : base(client)
        {
            _receiptLineItemClient = receiptLineItemClient;
        }

        public async Task<SBReceipt> CreateAsync(long merchantId, ReceiptCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/merchants/{merchantId}/receipts", request, options, cancellationToken);
        }

        public async Task<SBReceipt> GetByIdAsync(long merchantId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/merchants/{merchantId}/receipts/{id}", options, cancellationToken);
        }

        public async Task<SBReceipt> DeleteAsync(long merchantId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/merchants/{merchantId}/receipts/{id}", options, cancellationToken);
        }

        public async Task<SBList<SBReceipt>> ListAsync(long merchantId, ReceiptListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/merchants/{merchantId}/receipts", request, options, cancellationToken);
        }

        public async Task<SBReceipt> UpdateAsync(long merchantId, long id, ReceiptUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/merchants/{merchantId}/receipts/{id}", request, options, cancellationToken);
        }

        public async Task<SBReceiptLineItem> CreateReceiptLineItemAsync(long merchantId, long receiptId, ReceiptLineItemCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<ReceiptLineItemCreateRequest, SBReceiptLineItem>($"/v1/merchants/{merchantId}/receipts/{receiptId}/items", request, options, cancellationToken);
        }

        public async Task<SBReceiptLineItem> DeleteReceiptLineItemAsync(long merchantId, long receiptId, long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync<SBReceiptLineItem>($"/v1/merchants/{merchantId}/receipts/{receiptId}/items/{id}", options, cancellationToken);
        }

        public async Task<SBReceiptLineItem> UpdateReceiptLineItemAsync(long merchantId, long receiptId, long id, ReceiptLineItemUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<ReceiptLineItemUpdateRequest, SBReceiptLineItem>($"/v1/merchants/{merchantId}/receipts/{receiptId}/items/{id}", request, options, cancellationToken);
        }

        public async Task<List<SBReceipt>> BatchCreateAsync(long merchantId, List<ReceiptCreateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync<List<ReceiptCreateRequest>, List<SBReceipt>>($"/v1/merchants/{merchantId}/receipts/batch", request, options, cancellationToken);
        }

        public async Task<List<SBReceipt>> BatchUpdateAsync(long merchantId, List<ReceiptBatchItemUpdateRequest> request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync<List<ReceiptBatchItemUpdateRequest>, List<SBReceipt>>($"/v1/merchants/{merchantId}/receipts/batch", request, options, cancellationToken);
        }

        public async Task<SBReceipt> CreatePaymentAsync(long merchantId, long receiptId, ReceiptCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/merchants/{merchantId}/receipts/{receiptId}/payments", request, options, cancellationToken);
        }

        public async Task<SBReceipt> GetByIdPaymentAsync(long merchantId, long receiptId, long paymentId, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/merchants/{merchantId}/receipts/{receiptId}/payments/{paymentId}", options, cancellationToken);
        }

        public async Task<SBReceipt> DeletePaymentAsync(long merchantId, long receiptId, long paymentId, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/merchants/{merchantId}/receipts/{receiptId}/payments/{paymentId}", options, cancellationToken);
        }

        public async Task<SBList<SBReceipt>> ListPaymentsAsync(long merchantId, long receiptId, ReceiptListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/merchants/{merchantId}/receipts/{receiptId}/payments", request, options, cancellationToken);
        }

        public async Task<SBReceipt> UpdatePaymentAsync(long merchantId, long receiptId, long paymentId, ReceiptUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/merchants/{merchantId}/receipts/{receiptId}/payments/{paymentId}", request, options, cancellationToken);
        }
    }
}
