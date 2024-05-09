using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Entities.Batch
{
    public record SBBatch<T>
    {
        public List<T> Items { get; set; }
    }
}
