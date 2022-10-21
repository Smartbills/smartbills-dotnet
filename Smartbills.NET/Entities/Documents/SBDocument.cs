using System;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Documents
{
    public record SBDocument
    {

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }


        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonPropertyName("user_id")]
        public long? UserId { get; set; }
    }
}
