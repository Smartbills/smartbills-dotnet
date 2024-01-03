namespace Smartbills.NET.Entities.Barcode
{
    public record SBBarcode
    {
        public SBBarcodeType Type { get; set; }
        public string Value { get; set; }
    }
}
