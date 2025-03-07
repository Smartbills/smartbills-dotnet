namespace Smartbills.NET.Services
{
    public class MerchantBatchUpdateRequest
    {
        public long Id { get; set; }
        public MerchantUpdateRequest Request { get; set; }
    }
}