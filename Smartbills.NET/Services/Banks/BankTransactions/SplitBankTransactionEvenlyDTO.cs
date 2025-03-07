using System.Collections.Generic;

namespace Smartbills.NET.Services.BankTransactions
{
    public class SplitBankTransactionEvenlyDTO
    {
        public List<long> Users { get; set; } = new List<long>();
    }
}
