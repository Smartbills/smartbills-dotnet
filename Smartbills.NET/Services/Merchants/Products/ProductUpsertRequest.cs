namespace Smartbills.NET.Services.Products
{
    public record ProductUpsertRequest : ProductCreateRequest, IUpsertRequest
    {
        public long? Id { get; set; }
    }
}
