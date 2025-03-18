namespace Smartbills.NET.Services.Merchants.Locations
{
    public record LocationUpsertRequest : LocationCreateRequest, IUpsertRequest
    {
        public long? Id { get; set; }
    }
}
