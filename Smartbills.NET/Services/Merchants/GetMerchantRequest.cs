namespace Smartbills.NET.Services
{
    public record GetMerchantRequest : BaseRequest
    {
        public long CompanyId { get; set; }
    }
}