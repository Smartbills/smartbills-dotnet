using System.Text.Json.Serialization;

namespace Smartbills.NET.Services._base
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