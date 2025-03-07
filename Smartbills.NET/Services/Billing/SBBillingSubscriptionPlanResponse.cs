﻿using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Money;

namespace Smartbills.NET.Services.Billing
{

    public record SBBillingSubscriptionPlanResponse : SBEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public SBMoney Amount { get; set; }
    }
}
