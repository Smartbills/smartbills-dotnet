using Microsoft.AspNetCore.Http;

namespace Smartbills.NET.Services.Files
{
    public record FileUpdateRequest
    {
        public IFormFile File { get; set; }
    }
}
