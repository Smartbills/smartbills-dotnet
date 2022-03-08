using System.Text.Json.Serialization;

namespace Smartbills.Client.Services
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