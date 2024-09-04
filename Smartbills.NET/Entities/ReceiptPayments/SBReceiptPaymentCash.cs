
using Smartbills.NET.Entities.Money;
using System.Data.SqlTypes;

namespace Smartbills.NET.Entities.ReceiptPayments
{
    public record SBReceiptPaymentCash
    {
        public SBMoney CashGiven { get; set; }
        public SBMoney ChangeReturned { get; set; }
    }
}
