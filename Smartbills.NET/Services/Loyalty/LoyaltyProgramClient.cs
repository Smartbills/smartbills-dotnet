using System.Threading.Tasks;
using Smartbills.NET.Infrastructure;
using Smartbills.NET.Entities.Loyalty;
using Smartbills.NET.Services;

namespace Smartbills.SDK.Services.Loyalty
{
    //public interface ILoyaltyProgramService
    //{
    //    Task<LoyaltyProgramResponse> GetByIdAsync(long id);
    //    Task<LoyaltyProgramResponse> GetRewardByIdAsync(long id);
    //}

    //public class LoyaltyProgramClient : Service<LoyaltyProgramResponse>, ILoyaltyProgramService
    //{
    //        public LoyaltyProgramClient(ISmartbillsClient smartbills) : base(smartbills)
    //        {
    //        }


    //        public async Task<LoyaltyProgramResponse> GetByIdAsync(long id)
    //    {
    //        return await GetEntityByIdAsync<LoyaltyProgramResponse>($"loyalty/programs/{id}");
    //    }

    //    public async Task<LoyaltyProgramResponse> GetRewardByIdAsync(long id)
    //    {
    //        return await GetEntityByIdAsync<LoyaltyProgramResponse>($"loyalty/rewards/{id}");
    //    }
    //}
}