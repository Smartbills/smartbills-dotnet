namespace Smartbills.NET.Services.PromoCodes
{
    public record PromoCodeUpsertRequest : PromoCodeCreateRequest, IUpsertRequest
    {
        public long? Id { get; set; }
    }
}
