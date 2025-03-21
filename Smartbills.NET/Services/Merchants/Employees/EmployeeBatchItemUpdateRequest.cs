using Smartbills.NET.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Services.Merchants.Employees
{

    public record EmployeeBatchItemUpdateRequest : EmployeeUpdateRequest, ISmartbillsEntity
    {
        public long Id { get; set; }
    }

}
