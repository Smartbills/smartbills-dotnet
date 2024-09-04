using Smartbills.NET.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Services.Receipts
{

    public record ReceiptBatchItemUpdateRequest : ReceiptUpdateRequest, ISmartbillsEntity
    {
        public long Id { get; set; }
    }
}
