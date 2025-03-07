using System.Collections.Generic;

namespace Smartbills.NET.Services.Reviews
{
    public record ReviewUpdateRequest
    {
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}
