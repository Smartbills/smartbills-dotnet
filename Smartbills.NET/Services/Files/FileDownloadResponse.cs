using System.IO;

namespace Smartbills.NET.Services.Files
{
    public record FileDownloadResponse
    {
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public Stream Stream { get; set; }
    }
}