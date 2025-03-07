namespace Smartbills.NET.Services.Locations
{
    public record LocationUpsertRequest : LocationCreateRequest, IUpsertRequest
    {
        public long? Id { get; set; }
    }
}
