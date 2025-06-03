using System.Collections.Generic;
using Smartbills.NET.Entities.Taxes;

namespace Smartbills.NET.Services.Merchants.Taxes
{
    public record TaxUpdateRequest
    {
        public bool? IsActive { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public SBTaxType TaxType { get; set; }
        public string State { get; set; }
        public string Jurisdiction { get; set; }
    }
}
