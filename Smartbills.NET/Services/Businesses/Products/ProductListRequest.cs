using System;
using System.Collections.Generic;
using System.Text;
using Smartbills.NET.Abstractions;

namespace Smartbills.NET.Services.Merchants.Products
{
    public record ProductListRequest : ListRequest
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Tag { get; set; }
        public string Vendor { get; set; }
        public bool? IsActive { get; set; }
    }
}
