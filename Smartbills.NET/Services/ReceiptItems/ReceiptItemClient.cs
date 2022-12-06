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
    public class ReceiptItemClient : ClientBase<SBReceiptItem>, IReceiptItemClient
    {
        public ReceiptItemClient(ISmartbillsClient client) : base(client)
        {
        }

        public async Task<SmartbillsResponse<SBReceiptItem>> CreateAsync(CreateReceiptItemRequest createRequest, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/receipts-items", createRequest, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBReceiptItem>> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/receipts-items/{id}", cancellationToken);

        }

        public async Task<SmartbillsResponse<SBReceiptItem>> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/receipts-items/{id}", cancellationToken);
        }

        public async Task<SmartbillsResponse<SBReceiptItem>> UpdateAsync(long id, UpdateReceiptItemRequest createRequest, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/receipts-items/{id}", createRequest, cancellationToken);
        }
    }
}
