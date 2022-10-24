using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Locations;
using Smartbills.NET.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Locations
{
    public interface ILocationClient : 
        ICreatable<CreateLocationRequest, SBLocation>,
        IUpdatable<UpdateLocationRequest, SBLocation>,
        IDeletable<SBLocation>,
        IRetrievable<SBLocation>,
        IListable<ListRequest, List<SBLocation>>
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


        public async Task<SBLocation> CreateAsync(CreateLocationRequest createRequest, CancellationToken cancellationToken)
        {
            return await CreateEntityAsync($"/v1/locations/", createRequest, cancellationToken);
        }

        public async Task<SBLocation> DeleteAsync(long id, CancellationToken cancellationToken)
        {
            return await DeleteEntityAsync($"/v1/locations/${id}", cancellationToken);
        }

        public async Task<SBLocation> GetByIdAsync(long id, CancellationToken cancellationToken)
        {
            return await GetEntityByIdAsync($"/v1/locations/${id}", cancellationToken);
        }

        public async Task<List<SBLocation>> ListAsync(ListRequest request, CancellationToken cancellationToken = default)
        {
            return await GetEntityAsync<ListRequest,List<SBLocation>>($"/v1/locations/", request, cancellationToken);
        }

        public async Task<SBLocation> UpdateAsync(long id, UpdateLocationRequest request, CancellationToken cancellationToken)
        {
            return await UpdateEntityAsync($"/v1/locations/${id}", request, cancellationToken);
        }
    }
}
