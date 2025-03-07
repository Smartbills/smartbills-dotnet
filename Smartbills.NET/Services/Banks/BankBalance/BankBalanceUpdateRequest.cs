namespace Smartbills.NET.Services
{
    public record UpdateBankBalanceRequest
    {
        public decimal Current { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Limit { get; set; }
        public decimal Available { get; set; }
    }
}
