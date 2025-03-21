using System;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Banks
{

    public record SBBankTransaction : SBEntity
    {


        public decimal Amount { get; set; }

        public string CurrencyCode { get; set; }

        public string[] Categories { get; set; }

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
    }
}