namespace Smartbills.NET.Services.Merchants.Products.ProductOptions
{
    public record ProductOptionUpdateRequest
    {
        public string Name { get; set; }
        public string Values { get; set; }
    }
}
