using Smartbills.NET.Abstractions;
using Smartbills.NET.Services.Batches;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Services.Employees
{

    public record EmployeeBatchItemUpdateRequest : EmployeeUpdateRequest, ISmartbillsEntity
    {
        public long Id { get; set; }
    }
}
