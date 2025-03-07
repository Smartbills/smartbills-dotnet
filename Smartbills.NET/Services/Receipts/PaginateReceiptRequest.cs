using System.Collections.Generic;

namespace Smartbills.NET.Services
{
    public record ReceiptListRequest : ListRequest
    {
        public string Fields { get; set; }
        public bool? HasBankTransaction { get; set; } = null;

        public List<long> Customers { get; set; } = new List<long>();

        public List<long> Locations { get; set; } = new List<long>();

        public List<long> PromoCodes { get; set; } = new List<long>();

    }
}
