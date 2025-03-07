namespace Smartbills.NET.Services.Locations
{
    public record LocationBatchUpdateRequest : LocationUpdateRequest, IUpsertRequest
    {
        public long? Id { get; set; }
    }
}
