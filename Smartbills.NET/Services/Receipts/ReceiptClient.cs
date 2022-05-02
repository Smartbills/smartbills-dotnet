using Smartbills.Client.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{

    public interface IReceiptClient : ICreateable<Receipt, CreateReceiptRequest>,
    IRetrievable<Receipt, GetReceiptRequest>,
        IUpdateable<Receipt, UpdateReceiptRequest>,
        IDeleteable<Receipt, DeleteReceiptRequest>
    {

    }
    public class ReceiptClient :
    Service<Receipt>, IReceiptClient

    {
        public override string BasePath => "receipts";

        public ReceiptClient(ISmartbillsClient client) : base(client) { }


        public async Task<SmartbillsResponse<Receipt>> CreateAsync(CreateReceiptRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(options, requestOptions, cancellationToken);
        }
        public async Task<SmartbillsResponse<Receipt>> GetAsync(long id, GetReceiptRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }
        public async Task<SmartbillsResponse<Receipt>> DeleteAsync(long id, DeleteReceiptRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<Receipt>> UpdateAsync(long id, UpdateReceiptRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
