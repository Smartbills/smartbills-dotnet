using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Services.Batches
{
    public record BatchRequest<T>
    {
        public List<T> Items { get; set; } = new List<T>();
    }
}
