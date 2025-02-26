using System.Threading.Tasks;
using Smartbills.SDK.Entities;
using Smartbills.SDK.Entities.Loyalty;

namespace Smartbills.SDK.Services.Loyalty
{
    public interface ILoyaltyProgramService
    {
        Task<LoyaltyProgramResponse> GetByIdAsync(long id);
        Task<LoyaltyProgramResponse> GetRewardByIdAsync(long id);
        Task<string> RedeemRewardAsync(long id, LoyaltyRewardRedeemRequest request);
    }

    public class LoyaltyProgramService : ServiceBase, ILoyaltyProgramService
    {
        public LoyaltyProgramService(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<LoyaltyProgramResponse> GetByIdAsync(long id)
        {
            return await GetAsync<LoyaltyProgramResponse>($"loyalty/programs/{id}");
        }

        public async Task<LoyaltyProgramResponse> GetRewardByIdAsync(long id)
        {
            return await GetAsync<LoyaltyProgramResponse>($"loyalty/rewards/{id}");
        }

        public async Task<string> RedeemRewardAsync(long id, LoyaltyRewardRedeemRequest request)
        {
            return await PostAsync<string>($"loyalty/rewards/{id}/redeem", request);
        }
    }
}