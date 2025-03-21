namespace Smartbills.NET.Services.Merchants
{
    public class MerchantBatchUpdateRequest
    {
        public long Id { get; set; }
        public MerchantUpdateRequest Request { get; set; }
    }
}