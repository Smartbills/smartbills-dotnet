using Smartbills.NET.Entities.Products;

namespace Smartbills.NET.Entities.Products.Options
{
    public record SBProductOption : SBEntity
    {
        public string Name { get; set; }
        public string Values { get; set; }
    }
}
