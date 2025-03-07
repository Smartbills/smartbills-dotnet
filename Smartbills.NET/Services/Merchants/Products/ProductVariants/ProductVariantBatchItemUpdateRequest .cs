using Smartbills.NET.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Services.ProductVariants
{

    public record ProductVariantBatchItemUpdateRequest : ProductVariantUpdateRequest, ISmartbillsEntity
    {
        public long Id { get; set; }
    }
}
