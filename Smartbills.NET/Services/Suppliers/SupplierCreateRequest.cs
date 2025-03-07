using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Suppliers
{
    public record SupplierCreateRequest
    {
        public string PublicToken { get; set; }
    }
}
