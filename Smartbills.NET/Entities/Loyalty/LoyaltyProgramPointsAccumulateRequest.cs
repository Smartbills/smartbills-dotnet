namespace Smartbills.NET.Entities.Loyalty
{
    public class LoyaltyProgramPointsAccumulateRequest
    {
        public long ReceiptId { get; set; }
        public string LoyaltyProgramId { get; set; }
        public long Points { get; set; }
    }
}