namespace Smartbills.NET.Services.PromoCodes
{
    public record PromoCodeUpdateRequest
    {
        public bool IsActive { get; set; } = true;
    }
}
