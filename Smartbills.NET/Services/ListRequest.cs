using System.Text.Json.Serialization;

namespace Smartbills.NET.Services
{
    public record ListRequest
    {
        public ListRequest()
        {
        }

        
        public long PageSize { get; set; } = 25;

        
        public long Page { get; set; } = 1;
    }
}