using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Localized
{
    public record LocalizedValueCreateRequest
    {
        public string Locale { get; set; }
        public string Value { get; set; }
    }
}
