using Smartbills.NET.Entities;
using Smartbills.NET.Entities.Products;

namespace Smartbills.Client.Entities
{
    public class SBProductOption: SBProductEntityBase
    {
        public string Name { get; set; }
        public string Values { get; set; }
    }
}
