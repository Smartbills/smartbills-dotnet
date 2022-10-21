using System.Text.Json.Serialization;

namespace Smartbills.NET.Services
{
    public record ListRequest
    {
        public ListRequest()
        {
        }

        [JsonPropertyName("page_size")]
        public long PageSize { get; set; } = 25;

        [JsonPropertyName("page")]
        public long Page { get; set; } = 1;
    }
}