using Smartbills.NET.Entities.Money;

namespace Smartbills.NET.Services.Receipts.LineItems
{
    public record ReceiptLineItemModifierCreateRequest
    {
        public string ProductModifierId { get; set; }
        public int Quantity { get; set; } = 1;
        public SBMoney Price { get; set; }
        public SBMoney TotalPrice { get; set; }
        public string Name { get; set; }

        public ReceiptLineItemModifierCreateRequest(
            string productModifierId,
           SBMoney price,
            string name,
            int quantity = 1)
        {
            ProductModifierId = productModifierId;
            Price = price;
            Name = name;
            Quantity = quantity;
            TotalPrice = new SBMoney(Price.Amount * quantity, Price.Currency);
        }
    }
}