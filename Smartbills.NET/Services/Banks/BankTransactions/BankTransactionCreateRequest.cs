using Smartbills.NET.Abstractions;
using Smartbills.NET.Entities.Address;
using System;
using System.Collections.Generic;

namespace Smartbills.NET.Services.Banks.BankTransactions
{
    public record BankTransactionCreateRequest : IPlaidEntity
    {
        public long? BankAccountId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public List<string> Categories { get; set; }
        public string CheckNumber { get; set; }
        public DateTimeOffset Date { get; set; }
        public DateTimeOffset AuthorizedDate { get; set; }
        public SBAddress Address { get; set; }
        public string Name { get; set; }
        public string MerchantName { get; set; }
        public string PaymentChannel { get; set; }
        public bool Pending { get; set; }
        public string AccountOwner { get; set; }
        public string StoreNumber { get; set; }
        public string Website { get; set; }
        public string Logo { get; set; }
        public string PlaidId { get; set; }

    }
}
