namespace Smartbills.NET.Services
{
    public record BankAccountCreateRequest
    {
        public string Type { get; set; }
        public string Subtype { get; set; }
        public string Name { get; set; }
        public string Mask { get; set; }
        public string OfficialName { get; set; }
        public BankBalanceCreateRequest Balance { get; set; }
        public string PlaidId { get; set; }
    }
}
