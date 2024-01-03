using System.Text.Json.Serialization;

namespace Smartbills.NET.Services
{
    public record PaginationRequestBase
    {
        
        public int Page { get; set; } = 1;

        
        public int PageSize { get; set; } = 25;

    }
}
