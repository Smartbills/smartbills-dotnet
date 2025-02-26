namespace Smartbills.NET.Entities.Banks
{
    public record SBBankAccountBalance : SmartbillsEntityWithId
    {
        public decimal Current { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Limit { get; set; }
        public decimal Available { get; set; }
    }
}
