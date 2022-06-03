using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Documents
{
    public class UploadDocumentDTO
    {

        [JsonPropertyName("files")]
        public List<IFormFile> Files { get; set; }
    }
}
