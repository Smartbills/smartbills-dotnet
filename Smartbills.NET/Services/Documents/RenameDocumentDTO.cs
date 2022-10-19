using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Documents
{
    public class RenameDocumentDTO
    {

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
