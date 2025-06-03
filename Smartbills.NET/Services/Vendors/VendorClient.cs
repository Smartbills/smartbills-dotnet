using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Vendors;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Vendors
{
    public interface IVendorClient :
        ICreatable<VendorCreateRequest, SBVendor>,
        IRetrievableById<SBVendor>,
        IUpdatable<VendorUpdateRequest, SBVendor>,
        IDeletable<SBVendor>,
        IListable<VendorListRequest, SBVendor>
    {
    }

    public class VendorClient : Service<SBVendor>, IVendorClient
    {
        public VendorClient(ISmartbillsClient client) : base(client) { }

        public async Task<SBVendor> CreateAsync(VendorCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/vendors", request, options, cancellationToken);
        }

        public async Task<SBVendor> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/vendors/{id}", options, cancellationToken);
        }

        public async Task<SBVendor> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/vendors/{id}", options, cancellationToken);
        }

        public async Task<SBList<SBVendor>> ListAsync(VendorListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/vendors", request, options, cancellationToken);
        }

        public async Task<SBVendor> UpdateAsync(long id, VendorUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/vendors/{id}", request, options, cancellationToken);
        }
    }
}