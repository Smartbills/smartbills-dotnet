using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smartbills.NET.Entities.Money;

namespace Smartbills.NET.Services.Billing
{
    public class BillingSubscriptionPlanCreateRequest
    {
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public SBMoney Amount { get; set; }
        public int TrialPeriodDays { get; set; } = 0;
    }
}
