﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Loyalty.LoyaltyAccounts
{
    public record LoyaltyAccountUpdateRequest
    {
        public long ProgramId { get; set; }
        public long CustomerId { get; set; }
    }
}
