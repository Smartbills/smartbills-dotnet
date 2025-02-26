using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Receipts;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.ReceiptItems
{
    public interface IReceiptItemClient :
        IRetrievable<SBReceiptItem>,
        IDeletable<SBReceiptItem>,
        IUpdatable<ReceiptItemUpdateRequest, SBReceiptItem>,
        ICreatable<ReceiptItemCreateRequest, SBReceiptItem>
    { }
    public class ReceiptItemClient : Service<SBReceiptItem>, IReceiptItemClient
    {
        public ReceiptItemClient(ISmartbillsClient client) : base(client)
        {
        }

        public async Task<SBReceiptItem> CreateAsync(ReceiptItemCreateRequest ListRequest, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/receipts-items", ListRequest, options, cancellationToken);
        }

        public async Task<SBReceiptItem> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/receipts-items/{id}", options, cancellationToken);

        }

        public async Task<SBReceiptItem> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/receipts-items/{id}", options, cancellationToken);
        }

        public async Task<SBReceiptItem> UpdateAsync(long id, ReceiptItemUpdateRequest ListRequest, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/receipts-items/{id}", ListRequest, options,cancellationToken);
        }
    }
}
