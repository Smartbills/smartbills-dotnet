﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Loyalty.LoyaltyAccounts
{
    public class LoyaltyAccountCreatedWebhook
    {
        public string LoyaltyProgramId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public long CustomerId { get; set; }
    }
}
