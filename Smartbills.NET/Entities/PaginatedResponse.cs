using System.Collections.Generic;

namespace Smartbills.NET.Entities
{
    public record PaginatedResponse<T>
    {
        public List<T> Data { get; set; }
        public PaginationMetadata Metadata { get; set; }
    }
}
