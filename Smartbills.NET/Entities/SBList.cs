using System.Collections.Generic;

namespace Smartbills.NET.Entities
{
    public record SBList<T>
    {
        public List<T> Data { get; set; }
        public PaginationMetadata Metadata { get; set; }
    }
}
