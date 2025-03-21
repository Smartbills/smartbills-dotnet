namespace Smartbills.NET.Services.Reviews
{
    public record ReviewUpsertRequest : ReviewCreateRequest, IUpsertRequest
    {
        public long? Id { get; set; }
    }
}
