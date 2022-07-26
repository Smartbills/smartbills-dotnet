using Smartbills.NET.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services
{
    public interface ICompanyClient :
    IRetrievable<SBMerchant, GetReceiptRequest>,
    ICreatable<SBMerchant, CreateCompanyRequest>,
    IUpdatable<SBMerchant, UpdateCompanyRequest>
    {
    }
    public class CompanyClient :
    ClientBase<SBMerchant>,
        ICompanyClient

    {
        public override string BasePath => "companies";

        public CompanyClient(ISmartbillsClient client) : base(client) { }

        public async Task<SBMerchant> CreateAsync(CreateReceiptRequest data, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(data, cancellationToken);
        }
        public async Task<SBMerchant> GetAsync(long id, GetReceiptRequest data = null, CancellationToken cancellationToken = default)
        {

            return await base.GetEntityByIdAsync(id, data, cancellationToken);
        }

        public async Task<SBMerchant> CreateAsync(CreateCompanyRequest request, CancellationToken cancellationToken = default)
        {
            return await base.CreateEntityAsync(request, cancellationToken);
        }

        public async Task<SBMerchant> UpdateAsync(long id, UpdateCompanyRequest request, CancellationToken cancellationToken = default)
        {
            return await base.UpdateEntityAsync(id, request, cancellationToken);
        }
    }
}
