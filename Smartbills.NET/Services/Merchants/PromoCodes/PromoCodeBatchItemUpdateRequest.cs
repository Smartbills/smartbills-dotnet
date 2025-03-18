using Smartbills.NET.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Services.Merchants.PromoCodes
{

    public record PromoCodeBatchItemUpdateRequest : PromoCodeUpdateRequest, ISmartbillsEntity
    {
        public long Id { get; set; }
    }
}
