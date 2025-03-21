namespace Smartbills.NET.Services.Reviews
{
    public record ReviewListRequest : ListRequest
    {
        public long? UserId { get; set; }
        public int? MinRating { get; set; }
        public int? MaxRating { get; set; }
    }
}