using Smartbills.NET.Entities.Address;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Entities.Receipts
{
    public record SBReceiptMerchant: SmartbillsEntity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public string CustomerEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string Website { get; set; }
        public SBAddress Address { get; set; }
        public string Logo { get; set; }
    }
}
