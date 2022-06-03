using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Documents
{
    public class RenameDocumentDTO
    {

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
