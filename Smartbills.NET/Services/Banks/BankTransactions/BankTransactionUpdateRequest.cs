using Smartbills.NET.Abstractions;
using System;

namespace Smartbills.NET.Services.Banks.BankTransactions
{
    public record BankTransactionUpdateRequest : IPlaidEntity
    {
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public string Categories { get; set; }
        public string CategoryId { get; set; }
        public DateTime Date { get; set; }
        public DateTime AuthorizedDate { get; set; }
        //public SBAddress Address { get; set; }
        public string Name { get; set; }
        public string PaymentChannel { get; set; }
        public bool Pending { get; set; }
        public string AccountOwner { get; set; }
        public string StoreNumber { get; set; }
        public string PlaidId { get; set; }
    }
}
