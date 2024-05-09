using Smartbills.NET.Services.Batches;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Services.Customers
{

    public record CustomerBatchUpdateRequest : BatchRequest<CustomerBatchItemUpdateRequest>
    {
    }
}
