namespace Smartbills.NET.Services.Subscriptions
{
    public class SubscriptionCreateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int DurationInDays { get; set; }
    }
}