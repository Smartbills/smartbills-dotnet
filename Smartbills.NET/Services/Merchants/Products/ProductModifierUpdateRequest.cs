namespace Smartbills.NET.Services.Products
{
    public record ProductModifierUpdateRequest
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal? InitialPrice { get; set; }
        public bool Active { get; set; } = true;
        public int DisplayOrder { get; set; }
        public string Sku { get; set; }
        public string UPC { get; set; }
        public string Locale { get; set; }
        public long ModifierGroupId { get; set; }
    }
}