using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smartbills.NET.Abstractions;

namespace Smartbills.NET.Services.Merchants.Fees
{
    public record FeeListRequest : ListRequest
    {
        public string Type { get; set; }
        public string Category { get; set; }
    }
}
