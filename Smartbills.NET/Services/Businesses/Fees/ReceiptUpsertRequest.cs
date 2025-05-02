namespace Smartbills.NET.Services.Merchants.Fees
{
    public record FeeUpsertRequest : FeeCreateRequest, IUpsertRequest
    {
        public long? Id { get; set; }
    }
}
