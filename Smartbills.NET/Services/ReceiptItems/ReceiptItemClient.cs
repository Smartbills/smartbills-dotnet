using Smarbtills.NET.Services;
using Smartbills.NET.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services
{
    public interface IReceiptItemClient :
        IRetrievable<SBReceiptItem, GetReceiptItemRequest>,
        IDeletable<SBReceiptItem, DeleteReceiptItemRequest>,
        IUpdatable<SBReceiptItem, UpdateReceiptItemRequest>,
        ICreatable<SBReceiptItem, CreateReceiptItemRequest>
    { }
    public class ReceiptItemClient : Service<SBReceiptItem>, IReceiptItemClient
    {
        public ReceiptItemClient(ISBClient client) : base(client)
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

        public async Task<SBReceiptItem> GetAsync(long id, GetReceiptItemRequest request = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync(id, request, cancellationToken);
        }

        public async Task<SBReceiptItem> UpdateAsync(long id, UpdateReceiptItemRequest createRequest, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, createRequest, cancellationToken);
        }
    }
}
