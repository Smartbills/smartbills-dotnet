using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Customers
{
    public record CustomerUpdateRequest
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public string Email { get; set; }
        public bool IsTaxExempt { get; set; }
        public List<string> Tags { get; set; }
        public string Currency { get; set; }
        public bool AcceptsMarketing { get; set; }
        public string Phone { get; set; }
        public string Locale { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public bool Delinquent { get; set; }
    }
}
