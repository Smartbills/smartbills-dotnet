using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.ReceiptItems;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.ReceiptItems
{
    public interface IReceiptItemClient :
        IRetrievable<SBReceiptItem>,
        IDeletable<SBReceiptItem>,
        IUpdatable<UpdateReceiptItemRequest, SBReceiptItem>,
        ICreatable<CreateReceiptItemRequest, SBReceiptItem>
    { }
    public class ReceiptItemClient : Service<SBReceiptItem>, IReceiptItemClient
    {
        public ReceiptItemClient(ISmartbillsClient client) : base(client)
        {
        }

        public async Task<SBReceiptItem> CreateAsync(CreateReceiptItemRequest createRequest, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/receipts-items", createRequest, options, cancellationToken);
        }

        public async Task<SBReceiptItem> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/receipts-items/{id}", options, cancellationToken);

        }

        public async Task<SBReceiptItem> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/receipts-items/{id}", options, cancellationToken);
        }

        public async Task<SBReceiptItem> UpdateAsync(long id, UpdateReceiptItemRequest createRequest, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/receipts-items/{id}", createRequest, options,cancellationToken);
        }
    }
}
