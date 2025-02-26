using Smartbills.NET.Entities.Money;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.ReceiptPayments
{
    public class ReceiptPaymentCashCreateRequest
    {
        public SBMoney Supplied { get; set; }
        public SBMoney Change { get; set; }
    }
}
