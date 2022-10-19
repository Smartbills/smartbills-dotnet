using Smartbills.NET.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services
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
            return await base.CreateEntityAsync(createRequest, cancellationToken);
        }

        public async Task<SBReceiptItem> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync(id, cancellationToken);

        }

        public async Task<SBReceiptItem> GetByIdAsync(long id,  CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync(id,  cancellationToken);
        }

        public async Task<SBReceiptItem> UpdateAsync(long id, UpdateReceiptItemRequest createRequest, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, createRequest, cancellationToken);
        }
    }
}
