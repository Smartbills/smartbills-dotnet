using Smartbills.NET.Entities.Taxes;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Taxes
{
    public record TaxUpdateRequest : BaseRequest
    {
        public bool? Active { get; set; }
        public string Country { get; set; }
        public Dictionary<string, string> Description { get; set; }
        public Dictionary<string, string> Name { get; set; }
        public SBTaxType TaxType { get; set; }
        public string State { get; set; }
        public string Jurisdiction { get; set; }
    }
}
