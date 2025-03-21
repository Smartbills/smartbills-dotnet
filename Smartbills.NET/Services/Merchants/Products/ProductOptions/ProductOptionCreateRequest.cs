namespace Smartbills.NET.Services.Merchants.Products.ProductOptions
{
    public record ProductOptionCreateRequest
    {
        public string Name { get; set; }
        public string Values { get; set; }
    }
}
