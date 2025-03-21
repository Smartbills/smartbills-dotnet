using System.Collections.Generic;

namespace Smartbills.NET.Services.Banks.BankTransactions
{
    public class SplitBankTransactionDTO
    {
        public List<CreatePartialBankTransactionDTO> Users { get; set; } = new List<CreatePartialBankTransactionDTO>();
    }
}
