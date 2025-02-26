namespace Smartbills.NET.Entities.Loyalty
{
    public class LoyaltyProgramPointResponse
    {
        public long Points { get; set; }
        public long LoyaltyProgramId { get; set; }
        public long RuleId { get; set; }
        public long ReceiptId { get; set; }
    }
}