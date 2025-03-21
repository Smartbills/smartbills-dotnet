using Smartbills.NET.Abstractions;

namespace Smartbills.NET.Services.Merchants.Fees
{
    public record FeeBatchItemUpdateRequest : FeeUpdateRequest, ISmartbillsEntity
    {
        public long Id { get; set; }
    }
}
