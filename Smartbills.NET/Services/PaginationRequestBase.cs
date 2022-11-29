using System.Text.Json.Serialization;

namespace Smartbills.NET.Services
{
    public record PaginationRequestBase
    {
        [JsonPropertyName("page")]
        public int Page { get; set; } = 1;

        [JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 25;

    }
}
