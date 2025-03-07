using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Taxes
{
    public record TaxListRequest : ListRequest
    {
        public string TaxIdentificationNumber { get; set; }
        public string Type { get; set; }
    }
}
