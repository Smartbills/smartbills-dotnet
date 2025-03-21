using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Suppliers;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Suppliers
{
    public interface ISupplierClient :
        ICreatable<SupplierCreateRequest, SBSupplier>,
        IRetrievableById<SBSupplier>,
        IDeletable<SBSupplier>,
        IListable<SupplierListRequest, SBSupplier>
    {
    }

    public class SupplierClient : Service<SBSupplier>, ISupplierClient
    {
        public SupplierClient(ISmartbillsClient client) : base(client) { }

        public async Task<SBSupplier> CreateAsync(SupplierCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/suppliers", request, options, cancellationToken);
        }

        public async Task<SBSupplier> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/suppliers/{id}", options, cancellationToken);
        }

        public async Task<SBSupplier> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/suppliers/{id}", options, cancellationToken);
        }

        public async Task<SBList<SBSupplier>> ListAsync(SupplierListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/suppliers", request, options, cancellationToken);
        }


    }
}