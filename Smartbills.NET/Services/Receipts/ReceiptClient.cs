using Smartbills.NET.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services
{

    public interface IReceiptClient : ICreatable<Receipt, CreateReceiptRequest>,
        IRetrievable<Receipt>,
        IUpdatable<Receipt, UpdateReceiptRequest>,
        IDeletable<Receipt>
    {

    }
    public class ReceiptClient : ClientBase<Receipt>, IReceiptClient

    {
        public override string BasePath => "receipts";
        private readonly string ReceiptItemPath = "items";

        public ReceiptClient(ISmartbillsClient client) : base(client) { }


        public async Task<Receipt> CreateAsync(CreateReceiptRequest options, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(options, cancellationToken);
        }
        public async Task<Receipt> GetByIdAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityByIdAsync(id, cancellationToken);
        }
        public async Task<Receipt> DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync(id, cancellationToken);
        }

        public async Task<Receipt> UpdateAsync(long id, UpdateReceiptRequest options, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, options, cancellationToken);
        }

        public async Task<SBReceiptItem> CreateAsync(long parentId, CreateReceiptItemRequest data, CancellationToken cancellationToken = default)
        {
            return await base.CreateChildAsync<CreateReceiptItemRequest, SBReceiptItem>(parentId, this.ReceiptItemPath, data, cancellationToken);
        }

        public async Task<SBReceiptItem> DeleteAsync(long parentId, long id, CancellationToken cancellationToken = default)
        {
            return await base.DeleteChildAsync<SBReceiptItem>(parentId, this.ReceiptItemPath, id, cancellationToken);

        }

        public async Task<SBReceiptItem> GetAsync(long parentId, long id, GetReceiptItemRequest data = null, CancellationToken cancellationToken = default)
        {
            return await base.GetChildByIdAsync<GetReceiptItemRequest, SBReceiptItem>(parentId, this.ReceiptItemPath, id, data, cancellationToken);
        }

        public async Task<SBReceiptItem> UpdateAsync(long parentId, long id, UpdateReceiptItemRequest data, CancellationToken cancellationToken = default)
        {
            return await base.UpdateChildAsync<UpdateReceiptItemRequest, SBReceiptItem>(parentId, this.ReceiptItemPath, id, data, cancellationToken);
        }
    }
}
