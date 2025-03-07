namespace Smartbills.NET.Services.Customers
{
    public record CustomerUpsertRequest : CustomerCreateRequest, IUpsertRequest
    {
        public long? Id { get; set; }
    }
}
