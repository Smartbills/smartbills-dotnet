namespace Smartbills.NET.Services.Merchants.Locations
{
    public record LocationBatchUpdateRequest : LocationUpdateRequest, IUpsertRequest
    {
        public long? Id { get; set; }
    }
}
