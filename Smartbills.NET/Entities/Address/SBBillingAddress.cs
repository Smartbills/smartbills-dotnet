﻿using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Address
{
    public record SBBillingAddress
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public SBAddress Address { get; set; }
        public string Comapny { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
