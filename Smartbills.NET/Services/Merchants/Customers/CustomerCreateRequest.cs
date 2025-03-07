using System;
using System.Collections.Generic;
using Smartbills.NET.Entities.Address;

namespace Smartbills.NET.Services
{
    public record CustomerCreateRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set; }
        public SBAddress Address { get; set; }
        public SBBillingAddress BillingAddress { get; set; }
        public SBBillingAddress ShippingAddress { get; set; }
        public bool IsTaxExempt { get; set; }
        public List<string> Tags { get; set; }
        public string Currency { get; set; }
        public bool AcceptsMarketing { get; set; }
        public string PhoneNumber { get; set; }
        public string Nickname { get; set; }
        public string Note { get; set; }
        public string Locale { get; set; }

        public string AccountNumber { get; set; }
        public string CustomerNumber { get; set; }
        public DateTimeOffset? BirthDate { get; set; }
        public Dictionary<string, string> Metadata { get; set; } = new();

    }
}
