using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Receipts.LineItems;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Receipts.LineItems
{
    public interface IReceiptLineItemClient :
        IRetrievableById<SBReceiptLineItem>,
        IDeletable<SBReceiptLineItem>,
        IUpdatable<ReceiptLineItemUpdateRequest, SBReceiptLineItem>,
        ICreatable<ReceiptLineItemCreateRequest, SBReceiptLineItem>
    { }
    public class ReceiptLineItemClient : Service<SBReceiptLineItem>, IReceiptLineItemClient
    {
        public ReceiptLineItemClient(ISmartbillsClient client) : base(client)
        {
        }

        public async Task<SBReceiptLineItem> CreateAsync(ReceiptLineItemCreateRequest ListRequest, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/receipts-items", ListRequest, options, cancellationToken);
        }

        public async Task<SBReceiptLineItem> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/receipts-items/{id}", options, cancellationToken);

        }

        public async Task<SBReceiptLineItem> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/receipts-items/{id}", options, cancellationToken);
        }

        public async Task<SBReceiptLineItem> UpdateAsync(long id, ReceiptLineItemUpdateRequest ListRequest, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/receipts-items/{id}", ListRequest, options, cancellationToken);
        }
    }
}
