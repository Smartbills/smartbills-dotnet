using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.ReceiptTaxes
{
    public class ReceiptTaxCreateRequest
    {

        public long? TaxId { get; set; }

        public string Name { get; set; }


        public decimal Rate { get; set; }


        public decimal Total { get; set; }

    }
}
