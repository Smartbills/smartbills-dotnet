using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Entities.ReceiptPayments
{

    public enum SBReceiptPaymentCardEntryMethod
    {
        Manual = 0,
        Swiped = 1,
        EMV = 2,
        OnFile = 3,
        Contactless = 4,
    }
}
