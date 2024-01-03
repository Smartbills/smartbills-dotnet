using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.ReceiptDiscounts
{
    public record ReceiptDiscountDTO
    {

        
        public string Amount { get; set; }

        
        public string Type { get; set; }
    }
}
