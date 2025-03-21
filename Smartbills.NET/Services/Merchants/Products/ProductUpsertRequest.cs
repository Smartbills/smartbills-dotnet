namespace Smartbills.NET.Services.Merchants.Products
{
    public record ProductUpsertRequest : ProductCreateRequest, IUpsertRequest
    {
        public long? Id { get; set; }
    }
}
