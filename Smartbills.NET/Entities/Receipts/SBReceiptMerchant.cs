using Smartbills.NET.Entities.Address;
namespace Smartbills.NET.Entities.Receipts
{
    public record SBReceiptMerchant : SBEntity
    {
        public string Name { get; set; }
        public string CustomerEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public SBAddress Address { get; set; }
        public string Logo { get; set; }
    }
}
