using Smartbills.NET.Services.LoyaltyRewards;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Loyalty
{
    public record LoyaltyProgramCreateRequest
    {
        public string Name { get; set; }
        public List<LoyaltyProgramRuleCreateRequest> Rules { get; set; } = new();
        public List<LoyaltyRewardCreateRequest> Rewards { get; set; } = new();

    }
}
