using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartbills.Client.Entities
{
    public class SBBankAccountBalance : SmartbillsEntityWithId
    {
        public decimal Current { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Limit { get; set; }
        public decimal Available { get; set; }
    }
}
