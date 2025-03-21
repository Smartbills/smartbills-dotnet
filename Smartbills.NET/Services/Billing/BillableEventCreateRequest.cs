namespace Smartbills.NET.Services.Billing
{
    public record BillableEventCreateRequest
    {
        public string EventName { get; set; }
        public decimal Value { get; set; }
        public long? UserId { get; set; }
        public long? OrganizationId { get; set; }
        public string ClientId { get; set; }
    }

}
