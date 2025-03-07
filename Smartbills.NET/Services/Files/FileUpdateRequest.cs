using Microsoft.AspNetCore.Http;

namespace Smartbills.NET.Services
{
    public record FileUpdateRequest
    {
        public IFormFile File { get; set; }
    }
}
