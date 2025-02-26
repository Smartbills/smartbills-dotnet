using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.ReceiptPayments
{
    public class ReceiptPaymentCashUpdateRequest
    {
        public decimal Supplied { get; set; }
        public decimal Change { get; set; }
    }
}
