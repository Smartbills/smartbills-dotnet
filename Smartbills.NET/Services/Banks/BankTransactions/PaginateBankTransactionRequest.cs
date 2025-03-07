
namespace Smartbills.NET.Services
{
    public record ListBankTransactionRequest : ListRequest
    {

        public bool? HasReceipt { get; set; } = null;
        public long? Ignored { get; set; } = null;
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 20;

        public long? AccountId { get; set; }
        public long? BankId { get; set; }

    }
}
