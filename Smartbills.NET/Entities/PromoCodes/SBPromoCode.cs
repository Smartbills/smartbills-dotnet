using Smartbills.NET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Entities.PromoCodes
{
    public record SBPromoCode: SmartbillsEntityWithId
    {
        public string Name { get; set; }
        public SBPromoCodeType Type { get; set; } = SBPromoCodeType.Amount;
        public bool IsDeleted { get; set; }
        public decimal Value { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }
    }
}
