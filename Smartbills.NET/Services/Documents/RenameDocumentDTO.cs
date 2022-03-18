using System.Text.Json.Serialization;

namespace Smartbills.Client.Entities.Documents
{
    public class RenameDocumentDTO
    {

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
