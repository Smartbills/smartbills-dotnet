using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;

namespace Smartbills.Client.Entities.Documents
{
    public class UploadDocumentDTO
    {

        [JsonPropertyName("files")]
        public List<IFormFile> Files { get; set; }
    }
}
