using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Locations;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Locations
{
    public interface ILocationClient : ICreatable<CreateLocationRequest, SBLocation>,
        IUpdatable<UpdateLocationRequest, SBLocation>,
        IDeletable<SBLocation>,
        IRetrievable<SBLocation>,
        IListable<ListRequest, SBLocation>
    {

    }
    public class LocationClient : ClientBase<SBLocation>, ILocationClient
    {

        public LocationClient(ISmartbillsClient client) : base(client)
        {

        }

        public LocationClient(SBClientCredentials credentials) : base(credentials)
        {
        }

        public LocationClient(string accessToken, string url = "https://api.smartbills.io") : base(accessToken, url)
        {
        }

        public LocationClient(string apiKey, string apiSecret, string url = "https://api.smartbills.io") : base(apiKey, apiSecret, url)
        {
        }

        public override string BasePath => "locations";

        public async Task<SBLocation> CreateAsync(CreateLocationRequest createRequest, CancellationToken cancellationToken)
        {
            return await CreateEntityAsync(createRequest, cancellationToken);
        }

        public async Task<SBLocation> DeleteAsync(long id, CancellationToken cancellationToken)
        {
            return await DeleteEntityAsync(id, cancellationToken);
        }

        public async Task<SBLocation> GetByIdAsync(long id, CancellationToken cancellationToken)
        {
            return await GetEntityByIdAsync(id, cancellationToken);
        }

        public async Task<SBLocation> ListAsync(ListRequest request, CancellationToken cancellationToken = default)
        {
            return await GetEntityAsync(request, cancellationToken);
        }

        public async Task<SBLocation> UpdateAsync(long id, UpdateLocationRequest request, CancellationToken cancellationToken)
        {
            return await UpdateEntityAsync(id, request, cancellationToken);
        }
    }
}
