namespace Smartbills.NET.Entities.Products
{
    public record SBProductVendor : SBEntity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}