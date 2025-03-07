using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Receipts
{
    public record SBReceiptPublicTokenResponse
    {
        public string Token { get; set; }
    }
}
