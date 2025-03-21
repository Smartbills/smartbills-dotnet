using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Vendors
{
    public record VendorListRequest : ListRequest
    {
        public string Query { get; set; }
    }
}
