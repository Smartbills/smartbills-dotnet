
using Smartbills.NET.Entities.Money;

namespace Smartbills.NET.Entities.ReceiptLineItems
{
    public record SBReceiptLineItemModifier : SBEntity
    {
        public string ProductModifierId { get; set; }
        public int Quantity { get; set; }
        public SBMoney Price { get; set; }
        public SBMoney TotalPrice { get; set; }
    }
}