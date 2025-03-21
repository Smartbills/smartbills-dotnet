using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Loyalty
{
    public record LoyaltyProgramPointsAccumulateRequest
    {
        public long ReceiptId { get; set; }
        public string LoyaltyProgramId { get; set; }
        public long Points { get; set; }
    }
}
