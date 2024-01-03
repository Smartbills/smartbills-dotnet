using Smartbills.NET.Entities.PromoCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.PromoCodes
{
    public record PromoCodeCreateRequest
    {
        public Dictionary<string, string> Name { get; set; }

        public decimal? Value { get; set; }

        public SBPromoCodeType Type { get; set; } = SBPromoCodeType.Amount;

        public bool Active { get; set; } = true;

    }
}
