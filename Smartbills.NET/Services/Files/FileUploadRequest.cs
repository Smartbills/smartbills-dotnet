using System.IO;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Smartbills.NET.Services.Files
{
    public record FileUploadRequest
    {
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public Stream Stream { get; set; }
        public string Base64 { get; set; }
        public string Url { get; set; }
        public IFormFile File { get; set; }
    }

    public record BatchFileUploadRequest<T> where T : FileUploadRequest
    {
        public List<T> Files { get; set; } = new();
        public bool Merge { get; set; } = false;
    }


    public record BatchFileUploadRequest
    {
        public List<IFormFile> Files { get; set; } = new();
        public bool Merge { get; set; } = false;
    }
}