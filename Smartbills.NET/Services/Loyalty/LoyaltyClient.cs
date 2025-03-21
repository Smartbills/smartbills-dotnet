using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Loyalty;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Loyalty
{
    public interface ILoyaltyProgramClient :
        ICreatable<LoyaltyCreateRequest, SBLoyaltyProgram>,
        IRetrievableById<SBLoyaltyProgram>,
        IUpdatable<LoyaltyUpdateRequest, SBLoyaltyProgram>,
        IDeletable<SBLoyaltyProgram>,
        IListable<LoyaltyListRequest, SBLoyaltyProgram>
    {
    }

    public class LoyaltyProgramClient : Service<SBLoyaltyProgram>, ILoyaltyProgramClient
    {
        public LoyaltyProgramClient(ISmartbillsClient client) : base(client) { }

        public async Task<SBLoyaltyProgram> CreateAsync(LoyaltyCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync("/v1/loyalty", request, options, cancellationToken);
        }

        public async Task<SBLoyaltyProgram> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/loyalty/{id}", options, cancellationToken);
        }

        public async Task<SBLoyaltyProgram> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/loyalty/{id}", options, cancellationToken);
        }

        public async Task<SBList<SBLoyaltyProgram>> ListAsync(LoyaltyListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync($"/v1/loyalty", request, options, cancellationToken);
        }

        public async Task<SBLoyaltyProgram> UpdateAsync(long id, LoyaltyUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/loyalty/{id}", request, options, cancellationToken);
        }
    }
}