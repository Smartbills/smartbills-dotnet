namespace Smartbills.NET.Entities.Money
{
    public record SBMoney
    {
        public SBMoney() { }
        public SBMoney(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }
        public string Currency { get; set; } = "CAD";
        public decimal Amount { get; set; } = 0m;
    }
}
