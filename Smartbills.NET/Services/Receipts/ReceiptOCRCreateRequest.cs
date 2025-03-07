using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smartbills.NET.Entities.Receipts;

namespace Smartbills.NET.Services.Receipts
{
    public record ReceiptOCRCreateRequest : ReceiptCreateRequest
    {
        public SBReceiptAccuracy Accuracy { get; set; }
    }


}
