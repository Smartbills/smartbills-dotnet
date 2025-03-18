using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Merchants.Locations
{
    public record LocationFindRequest
    {
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
    }
}
