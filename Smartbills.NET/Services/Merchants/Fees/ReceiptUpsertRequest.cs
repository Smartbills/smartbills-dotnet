namespace Smartbills.NET.Services.Fees
{
    public record FeeUpsertRequest : FeeCreateRequest, IUpsertRequest
    {
        public long? Id { get; set; }
    }
}
