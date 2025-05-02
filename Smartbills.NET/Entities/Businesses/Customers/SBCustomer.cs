using Smartbills.NET.Entities.Address;
using System;
using System.Collections.Generic;

namespace Smartbills.NET.Entities.Customers
{
    public record SBCustomer : SBEntity, ITimestamp
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public SBBillingAddress BillingAddress { get; set; }
        public SBBillingAddress ShippingAddress { get; set; }
        public string PhoneNumber { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
        public string Currency { get; set; }
        public bool AcceptsMarketing { get; set; } = false;
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
