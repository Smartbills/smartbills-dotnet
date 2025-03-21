﻿using Smartbills.NET.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Services.Merchants.Products.ProductImages
{

    public record ProductImageBatchItemUpdateRequest : ProductImageUpdateRequest, ISmartbillsEntity
    {
        public long Id { get; set; }
    }
}
