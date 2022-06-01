
using RestSharp;
using Smarbtills.NET.Services;
using Smartbills.Client.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.Client.Services
{
    public interface ICompanyClient :
    IRetrievable<SBCompany, GetReceiptRequest>,
    ICreatable<SBCompany, CreateCompanyRequest>,
    IUpdatable<SBCompany, UpdateCompanyRequest>
    {
    }
    public class CompanyClient :
    Service<SBCompany>,
        ICompanyClient

    {
        public override string BasePath => "companies";

        public CompanyClient(SmartbillsClient client) : base(client) { }

        public async Task<SBCompany> CreateAsync(CreateReceiptRequest data, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(data, cancellationToken);
        }
        public async Task<SBCompany> GetAsync(long id, GetReceiptRequest data = null, CancellationToken cancellationToken = default)
        {

            return await base.GetEntityAsync(id, data, cancellationToken);
        }

        public async Task<SBCompany> CreateAsync(CreateCompanyRequest request, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(request, cancellationToken);
        }

        public async Task<SBCompany> UpdateAsync(long id, UpdateCompanyRequest request, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, request, cancellationToken);
        }
    }
}
