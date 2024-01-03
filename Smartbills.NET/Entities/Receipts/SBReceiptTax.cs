using Smartbills.NET.Entities.Taxes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Entities.Receipts
{
    public record SBReceiptTax
    {
        public long? Id { get; set; }
        public decimal Total { get; set; }
        public string TaxIdentificationNumber { get; set; }
        public decimal Rate { get; set; }
        public string Name { get; set; }

        public SBTax Tax { get; set; }

    }
}
