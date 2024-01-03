using Smartbills.NET.Abstractions;
using Smartbills.NET.Services.Addresses;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.BankTransactions
{
    public record BankTransactionUpdateRequest : BaseRequest, IPlaidEntity
    {

        public long? BankAccountId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public List<string> Categories { get; set; }
        public string CheckNumber { get; set; }
        public DateTimeOffset Date { get; set; }
        public DateTimeOffset AuthorizedDate { get; set; }
        public AddressCreateRequest Address { get; set; }
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