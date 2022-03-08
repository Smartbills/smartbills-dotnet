
using System;
using System.Threading;
using System.Threading.Tasks;
using Smartbills.Client.Entities;

namespace Smartbills.Client.Services
{
    public interface ICompanyClient :
    IRetrievable<SBCompany, GetReceiptRequest>
    {
    }
    public class CompanyClient :
    Service<SBCompany>,
        ICompanyClient

    {
        public override string BasePath => "v1/companies";

        public CompanyClient(ISmartbillsClient client) : base(client) { }

        public async Task<SmartbillsResponse<SBCompany>> CreateAsync(CreateReceiptRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(options, requestOptions, cancellationToken);
        }
        public async Task<SmartbillsResponse<SBCompany>> GetAsync(Guid id, GetReceiptRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {

            return await base.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }
    }
}
