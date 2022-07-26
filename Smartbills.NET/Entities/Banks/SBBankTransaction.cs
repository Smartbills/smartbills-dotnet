using System;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities
{

    public class SBBankTransaction : SmartbillsEntityWithId
    {

        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }
        [JsonPropertyName("currency_code")]
        public string CurrencyCode { get; set; }
        [JsonPropertyName("categories")]
        public string[] Categories { get; set; }
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }
        [JsonPropertyName("authorized_date")]

        public DateTime AuthorizedDate { get; set; }
        //public SBAddress Address { get; set; }
        [JsonPropertyName("name")]

        public string Name { get; set; }
        [JsonPropertyName("payment_channel")]
        public string PaymentChannel { get; set; }
        [JsonPropertyName("pending")]
        public bool Pending { get; set; }
        [JsonPropertyName("account_owner")]
        public string AccountOwner { get; set; }
        [JsonPropertyName("store_number")]
        public string LocationNumber { get; set; }
        [JsonPropertyName("bank_account_id")]
        public long BankAccountId { get; set; }
        [JsonPropertyName("receipt_id")]
        public long? ReceiptId { get; set; }
    }
}