using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.NET.Entities.Money
{
    public  record SBMoney
    {
        public string Currency { get; set; }
        public decimal Amount { get; set; }
    }
}
