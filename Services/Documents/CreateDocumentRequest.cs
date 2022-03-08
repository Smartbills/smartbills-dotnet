using System;
using System.Text.Json.Serialization;

namespace Smartbills.Client.Services
{
    public class CreateDocumentRequest
    {

        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }


        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonPropertyName("user_id")]
        public Guid? UserId { get; set; }
    }
}
