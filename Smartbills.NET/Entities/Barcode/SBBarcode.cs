namespace Smartbills.NET.Entities.Barcode
{
    public record SBReceiptBarcode
    {
        public SBBarcodeType Type { get; set; }
        public string Value { get; set; }
    }
}
