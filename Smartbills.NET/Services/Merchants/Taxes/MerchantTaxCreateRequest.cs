namespace Smartbills.NET.Services.Merchants.Taxes
{
    public record CreateMerchantTaxDTO
    {
        public string Name { get; set; }

        public decimal Rate { get; set; }

        public string TIN { get; set; }
    }
}
