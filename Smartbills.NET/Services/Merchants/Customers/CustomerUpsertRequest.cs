namespace Smartbills.NET.Services.Merchants.Customers
{
    public record CustomerUpsertRequest : CustomerCreateRequest, IUpsertRequest
    {
        public long? Id { get; set; }
    }
}
