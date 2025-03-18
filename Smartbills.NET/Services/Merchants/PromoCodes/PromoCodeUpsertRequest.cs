namespace Smartbills.NET.Services.Merchants.PromoCodes
{
    public record PromoCodeUpsertRequest : PromoCodeCreateRequest, IUpsertRequest
    {
        public long? Id { get; set; }
    }
}
