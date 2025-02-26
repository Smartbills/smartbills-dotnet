using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Documents
{
    public class UploadDocumentDTO
    {

        
        public List<IFormFile> Files { get; set; }
    }
}
