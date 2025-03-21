using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smartbills.NET.Abstractions;

namespace Smartbills.NET.Services.Merchants.Taxes
{
    public record TaxListRequest : ListRequest
    {
        public string Country { get; set; }
        public string State { get; set; }
        public string Jurisdiction { get; set; }
    }
}
