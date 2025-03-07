﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.NET.Services.Customers
{
    public class CustomerCalculatedFieldsUpdateRequest
    {
        public decimal TotalAmount { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}
