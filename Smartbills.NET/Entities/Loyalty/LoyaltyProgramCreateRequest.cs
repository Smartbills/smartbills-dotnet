using System.Collections.Generic;

namespace Smartbills.NET.Entities.Loyalty
{
    public class LoyaltyProgramCreateRequest
    {
        public string Name { get; set; }
        public List<LoyaltyProgramRuleCreateRequest> Rules { get; set; } = new();
        public List<LoyaltyRewardCreateRequest> Rewards { get; set; } = new();
    }
}