using Smartbills.NET.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Services.Customers
{

    public record CustomerBatchItemUpdateRequest : CustomerUpdateRequest, ISmartbillsEntity
    {
        public long Id { get; set; }
    }
}
