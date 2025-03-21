using Smartbills.NET.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Services.Merchants.Locations
{

    public record LocationBatchItemUpdateRequest : LocationUpdateRequest, ISmartbillsEntity
    {
        public long Id { get; set; }
    }
}
