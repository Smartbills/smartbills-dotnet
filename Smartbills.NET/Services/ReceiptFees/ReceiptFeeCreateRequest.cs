using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.ReceiptFees
{
    public class ReceiptFeeCreateRequest
    {

        
        public string Name { get; set; }
        
        public decimal Amount { get; set; }
        
        public decimal Rate { get; set; }
        
        public decimal Total { get; set; }
        
        public string Type { get; set; }
    }
}
