using Smartbills.NET.Entities;

namespace Smartbills.NET.Services.Merchants.Taxes
{
    public record MerchantTaxDTO : SBEntity
    {
        public string Name { get; set; }

        public decimal Rate { get; set; }

        public string TIN { get; set; }
    }
}
