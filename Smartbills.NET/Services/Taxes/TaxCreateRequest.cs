using Smartbills.NET.Entities.Taxes;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Taxes
{
    public record TaxCreateRequest : BaseRequest
    {
        public Dictionary<string, string> LocalizedDescription { get; set; }
        public Dictionary<string, string> LocalizedName { get; set; }

        public string Description { get; set; }
        public string Name { get; set; }

        public bool? Active { get; set; }
        public string Country { get; set; }

        public SBTaxType? TaxType { get; set; }
        public decimal Percentage { get; set; }
        public string State { get; set; }
        public bool? Inclusive { get; set; }
        public string Jurisdiction { get; set; }
        public string TaxIdentificationNumber { get; set; }
    }
}
