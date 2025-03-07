
namespace Smartbills.NET.Services.BulkJobs
{
    public record BulkJobItem
    {
        public bool Success { get; set; }
        public long? Id { get; set; }
        public string Error { get; set; }
    }
}