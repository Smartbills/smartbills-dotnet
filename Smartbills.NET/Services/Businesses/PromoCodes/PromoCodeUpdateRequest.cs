namespace Smartbills.NET.Services.Merchants.PromoCodes
{
    public record PromoCodeUpdateRequest
    {
        public bool IsActive { get; set; } = true;
    }
}
