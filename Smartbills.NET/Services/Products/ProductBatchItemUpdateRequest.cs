using Smartbills.NET.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Services.Products
{

    public record ProductBatchItemUpdateRequest : ProductUpdateRequest, ISmartbillsEntity
    {
        public long Id { get; set; }
    }
}
