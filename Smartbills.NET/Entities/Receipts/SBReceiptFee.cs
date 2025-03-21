using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Fees;
using Smartbills.NET.Entities.Money;

namespace Smartbills.NET.Entities.Receipts
{
    public record SBReceiptFee : ISmartbillsEntity
    {
        public long Id { get; set; }
        public SBFee Fee { get; set; }
        public SBMoney Amount { get; set; }
        public decimal Rate { get; set; }
        public SBMoney Total { get; set; }
        public string Type { get; set; }
    }
}
