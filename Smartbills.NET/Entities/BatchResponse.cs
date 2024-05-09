using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Entities
{
    public record BatchResponse<T>
    {
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
        public T Item { get; set; }
    }
}
