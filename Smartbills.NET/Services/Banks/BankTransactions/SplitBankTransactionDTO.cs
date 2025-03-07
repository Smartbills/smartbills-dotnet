using System.Collections.Generic;

namespace Smartbills.NET.Services.BankTransactions
{
    public class SplitBankTransactionDTO
    {
        public List<CreatePartialBankTransactionDTO> Users { get; set; } = new List<CreatePartialBankTransactionDTO>();
    }
}
