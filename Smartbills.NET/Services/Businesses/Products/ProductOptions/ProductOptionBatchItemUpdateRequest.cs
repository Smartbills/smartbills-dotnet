using Smartbills.NET.Abstractions;

namespace Smartbills.NET.Services.Merchants.Products.ProductOptions
{
    public record ProductOptionBatchItemUpdateRequest : ProductOptionUpdateRequest, ISmartbillsEntity
    {
        public long Id { get; set; }
    }
}
