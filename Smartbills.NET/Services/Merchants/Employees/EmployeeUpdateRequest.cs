﻿using System.Collections.Generic;
namespace Smartbills.NET.Services.Merchants.Employees
{
    public record EmployeeUpdateRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<long> LocationIds { get; set; } = new List<long>();
        public bool IsActive { get; set; } = true;
    }
}
