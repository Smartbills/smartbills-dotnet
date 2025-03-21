using System.Collections.Generic;

namespace Smartbills.NET.Services.Banks.BankTransactions
{
    public class SplitBankTransactionEvenlyDTO
    {
        public List<long> Users { get; set; } = new List<long>();
    }
}
