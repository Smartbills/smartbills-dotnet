namespace Smartbills.NET.Entities.Receipts
{
    public record SBReceiptAccuracy
    {
        public float? Date { get; set; }
        public float? DueDate { get; set; }
        public float? ReceiptId { get; set; }
        public float? SubTotal { get; set; }
        public float? TotalTaxes { get; set; }
        public float? Total { get; set; }
        public float? Currency { get; set; }
    }
}