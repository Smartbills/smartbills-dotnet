using Smartbills.NET.Services.Batches;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Services.Receipts
{
    public record ReceiptBatchUpsertRequest : BatchRequest<ReceiptUpsertRequest>
    {
    }
}
