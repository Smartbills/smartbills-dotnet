using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Abstractions
{
    public interface IUpsertRequest
    {
        public long? Id { get; set; }
    }
}
