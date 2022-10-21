
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Entities
{
    public record PaginatedResponse<T>
    {
        public List<T> Data { get; set; }
        public PaginationMetadata Metadata { get; set; }
    }
}
