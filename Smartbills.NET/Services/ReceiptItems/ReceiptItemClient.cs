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
        IUpdatable<SBReceiptItem, UpdateReceiptItemRequest>,
        ICreatable<SBReceiptItem, CreateReceiptItemRequest>
    { }
    public class ReceiptItemClient : ClientBase<SBReceiptItem>, IReceiptItemClient
    {
        public ReceiptItemClient(ISmartbillsClient client) : base(client)
        {
        }

        public override string BasePath => "receipt-items";


        public async Task<SBReceiptItem> CreateAsync(CreateReceiptItemRequest createRequest, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync(createRequest, cancellationToken);
        }

        public async Task<SBReceiptItem> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync(id, cancellationToken);

        }

        public async Task<SBReceiptItem> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync(id, cancellationToken);
        }

        public async Task<SBReceiptItem> UpdateAsync(long id, UpdateReceiptItemRequest createRequest, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync(id, createRequest, cancellationToken);
        }
    }
}
