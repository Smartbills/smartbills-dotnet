using System;

namespace Smartbills.NET.Services.Receipts
{
    public class ReceiptMev
    {
        public string EmployeeName { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Tps { get; set; }
        public decimal Tvq { get; set; }
        public long SerialNumber { get; set; }
        public long TransactionCount { get; set; }
        public string TransactionNumber { get; set; }
        public string VendorField { get; set; }
        public long DateOffset { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}
