using System.Collections.Generic;
using Smartbills.NET.Entities.Address;
using Smartbills.NET.Entities.Images;

namespace Smartbills.NET.Entities.Receipts
{
    public record SBReceiptLocation : SBEntity
    {
        public string Logo { get; set; }
        public string Name { get; set; }
        public virtual SBAddress Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<SBImage> Images { get; set; } = new List<SBImage>();
        public string FacebookUrl { get; set; }
        public string TwitterUsername { get; set; }
        public string InstagramUsername { get; set; }
        public string MerchantCategoryCode { get; set; }
        public string Timezone { get; set; }
    }
}