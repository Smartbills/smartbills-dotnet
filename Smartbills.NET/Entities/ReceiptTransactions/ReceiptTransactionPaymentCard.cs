using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Entities.ReceiptTransactions
{
    public record ReceiptTransactionPaymentCard
    {
        public string CardholderName { get; set; }
        public string CardholderFirstName { get; set; }
        public string CardholderLastName { get; set; }
        public string Country { get; set; }
        public string Brand { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }
        public string Fingerprint { get; set; }
        public string Last4 { get; set; }
        public string DynamicLast4 { get; set; }
        public string Bin { get; set; }
    }
}
