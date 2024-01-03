using Smartbills.NET.Entities.Discounts;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.ReceiptDiscounts
{
    public record ReceiptDiscountCreateRequest
    {

        public long? DiscountId { get; set; }



        public decimal Amount { get; set; }


        public string Name { get; set; }


        public decimal? Percentage { get; set; }


        public SBDiscountType Type { get; set; }

    }
}
