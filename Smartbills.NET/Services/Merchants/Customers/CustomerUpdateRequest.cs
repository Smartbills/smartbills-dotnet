using System.Collections.Generic;

namespace Smartbills.NET.Services
{
    public record CustomerUpdateRequest
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public bool TaxExempt { get; set; }
        public List<string> Tags { get; set; }
        public string Currency { get; set; }
        public bool AcceptsMarketing { get; set; }

        public string PhoneNumber { get; set; }

    }
}
