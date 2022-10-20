using System.Text.Json.Serialization;

namespace Smartbills.NET.Services
{
    public class ListRequest
    {
        public ListRequest()
        {
        }

        [JsonPropertyName("limit")]
        public long? Limit { get; set; }

    }
}