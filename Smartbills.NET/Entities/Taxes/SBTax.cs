using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Taxes
{
    public record SBTax : SmartbillsEntityWithId
    {
        public bool? Active { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public SBTaxType? TaxType { get; set; }
        public decimal Percentage { get; set; }
        public string State { get; set; }
        public bool? Inclusive { get; set; }
        public string Jurisdiction { get; set; }
        public string TaxIdentificationNumber { get; set; }
    }
}
