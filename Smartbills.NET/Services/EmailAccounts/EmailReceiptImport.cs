using System;

namespace Smartbills.NET.Services.EmailAccounts
{
    public class EmailReceiptImportRequest
    {
        public DateTimeOffset? StartDate { get; set; } = DateTimeOffset.MinValue;
        public DateTimeOffset? EndDate { get; set; } = DateTimeOffset.MaxValue;
    }
}