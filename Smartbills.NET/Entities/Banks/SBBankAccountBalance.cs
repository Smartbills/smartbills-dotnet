using Smartbills.NET.Entities._base;

namespace Smartbills.NET.Entities.Banks
{
    public class SBBankAccountBalance : SmartbillsEntityWithId
    {
        public decimal Current { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Limit { get; set; }
        public decimal Available { get; set; }
    }
}
