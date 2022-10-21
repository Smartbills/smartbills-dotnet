using Smartbills.NET.Entities.Products;

namespace Smartbills.NET.Entities.ProductOption
{
    public record SBProductOption : SBProductEntityBase
    {
        public string Name { get; set; }
        public string Values { get; set; }
    }
}
