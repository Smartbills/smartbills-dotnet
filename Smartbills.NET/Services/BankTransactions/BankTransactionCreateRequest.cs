using Smartbills.NET.Abstractions;
using System;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.BankTransactions
{
    public record BankTransactionCreateRequest : BaseRequest, IPlaidEntity
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
        
        public string LocationNumber { get; set; }
        
        public long BankAccountId { get; set; }
        
        public long? ReceiptId { get; set; }

        
        public string PlaidId { get; set; }
    }
}