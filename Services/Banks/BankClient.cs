
using System;
using System.Threading;
using System.Threading.Tasks;
using Smartbills.Client.Entities;

namespace Smartbills.Client.Services
{
    public interface IBankClient :
    ICreateable<SBBank, CreateBankRequest>,
    IRetrievable<SBBank, GetBankRequest>,
    IUpdateable<SBBank, UpdateBankRequest>,
    IDeleteable<SBBank, DeleteBankRequest>
    {
    }
    public class BankClient :
    Service<SBBank>, IBankClient

    {
        public override string BasePath => "v1/banks";

        public BankClient(ISmartbillsClient client) : base(client) { }

        public async Task<SmartbillsResponse<SBBank>> CreateAsync(CreateBankRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(options, requestOptions, cancellationToken);
        }
        public async Task<SmartbillsResponse<SBBank>> GetAsync(Guid id, GetBankRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.GetEntityAsync(id, options,requestOptions, cancellationToken);
        }
        public async Task<SmartbillsResponse<SBBank>> UpdateAsync(Guid id, UpdateBankRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, options,requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBBank>> DeleteAsync(Guid id, DeleteBankRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.DeleteEntityAsync(id, options,requestOptions, cancellationToken);
        }

    }
}
