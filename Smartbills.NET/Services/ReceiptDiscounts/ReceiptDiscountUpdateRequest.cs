using Smartbills.NET.Entities.Discounts;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.ReceiptDiscounts
{
    public class ReceiptDiscountUpdateRequest
    {

        public long? DiscountId { get; set; }



        public decimal Amount { get; set; }


        public string Name { get; set; }


        public decimal? Percentage { get; set; }


        public SBDiscountType Type { get; set; }
    }
}
