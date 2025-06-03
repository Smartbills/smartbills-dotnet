using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Businesses.Team.Members;
using Smartbills.NET.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Businesses.Team
{
    public interface ITeamMemberClient :
        IRetrievableById<SBTeamMember>,
        ICreatable<TeamMemberCreateRequest, SBTeamMember>,
        IUpdatable<TeamMemberUpdateRequest, SBTeamMember>,
        IDeletable<SBTeamMember>,
        IListable<TeamMemberListRequest, SBTeamMember>
    { }

    public class TeamMemberClient : Service<SBTeamMember>, ITeamMemberClient
    {
        public TeamMemberClient(ISmartbillsClient smartbills) : base(smartbills)
        {
        }

        public async Task<SBTeamMember> GetByIdAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await GetEntityByIdAsync($"/v1/businesses/team/members/{id}", options, cancellationToken);
        }

        public async Task<SBTeamMember> CreateAsync(TeamMemberCreateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await CreateEntityAsync($"/v1/businesses/team/members", request, options, cancellationToken);
        }

        public async Task<SBTeamMember> UpdateAsync(long id, TeamMemberUpdateRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await UpdateEntityAsync($"/v1/businesses/team/members/{id}", request, options, cancellationToken);
        }

        public async Task<SBTeamMember> DeleteAsync(long id, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await DeleteEntityAsync($"/v1/businesses/team/members/{id}", options, cancellationToken);
        }

        public async Task<SBList<SBTeamMember>> ListAsync(TeamMemberListRequest request, SBRequestOptions options = null, CancellationToken cancellationToken = default)
        {
            return await PaginateEntityAsync("/v1/businesses/team/members", request, options, cancellationToken);
        }
    }
}