using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smartbills.NET.Entities.Address;

namespace Smartbills.NET.Entities.Vendors
{
    public record SBVendor : SBEntity
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public SBAddress Address { get; set; }
        public string Website { get; set; }
    }
}
