
using Smartbills.Client.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface ICompanyClient :
    IRetrievable<SBCompany, GetReceiptRequest>,
    ICreateable<SBCompany, CreateCompanyRequest>,
    IUpdateable<SBCompany, UpdateCompanyRequest>
    {
    }
    public class CompanyClient :
    Service<SBCompany>,
        ICompanyClient

    {
        public override string BasePath => "companies";

        public CompanyClient(ISmartbillsClient client) : base(client) { }

        public async Task<SmartbillsResponse<SBCompany>> CreateAsync(CreateReceiptRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(options, requestOptions, cancellationToken);
        }
        public async Task<SmartbillsResponse<SBCompany>> GetAsync(long id, GetReceiptRequest options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {

            return await base.GetEntityAsync(id, options, requestOptions, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBCompany>> CreateAsync(CreateCompanyRequest request, RequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(request, options, cancellationToken);
        }

        public async Task<SmartbillsResponse<SBCompany>> UpdateAsync(long id, UpdateCompanyRequest request, RequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, request, options, cancellationToken);
        }
    }
}
