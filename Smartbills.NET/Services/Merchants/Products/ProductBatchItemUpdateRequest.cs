using Smartbills.NET.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Services.Merchants.Products
{

    public record ProductBatchItemUpdateRequest : ProductUpdateRequest, ISmartbillsEntity
    {
        public long Id { get; set; }
    }
}
