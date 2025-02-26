namespace Smartbills.NET.Entities.Loyalty
{
    public class LoyaltyAccountCreateRequest
    {
        public long ProgramId { get; set; }
        public long CustomerId { get; set; }
    }
}