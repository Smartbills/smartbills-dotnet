using Smartbills.NET.Entities.Barcode;

namespace Smartbills.NET.Services.Barcodes
{
    public record BarcodeCreateRequest : BaseRequest
    {
        public SBBarcodeType Type { get; set; }
        public string Text { get; set; }
    }
}
