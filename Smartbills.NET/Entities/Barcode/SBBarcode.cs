namespace Smartbills.NET.Entities.Barcode
{
    public record SBBarcode
    {
        public SBBarcodeType Type { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
    }
}
