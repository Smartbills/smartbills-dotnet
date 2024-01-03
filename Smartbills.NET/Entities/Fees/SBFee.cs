using Smartbills.NET.Abstractions;

namespace Smartbills.NET.Entities.Fees
{
    public record SBFee : ISmartbillsEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public decimal Rate { get; set; }
        public decimal Total { get; set; }
        public string Type { get; set; }
    }
}
