using System;
using System.Collections.Generic;

namespace Smartbills.NET.Entities.Customers
{
    public record SBReceiptCustomer : SBEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Company { get; set; }
    }
}