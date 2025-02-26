namespace Smartbills.NET.Entities.Loyalty
{
    public class LoyaltyProgramPointsAdjustRequest
    {
        public long ReceiptId { get; set; }
        public string LoyaltyProgramId { get; set; }
        public long Points { get; set; }
    }
}