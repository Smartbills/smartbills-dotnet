using Smartbills.NET.Entities.Barcode;
using Smartbills.NET.Services._base;

namespace Smartbills.NET.Services.Barcodes
{
    public record CreateBarcodeRequest : BaseRequest
    {
        public SBBarcodeType Type { get; set; }
        public string Text { get; set; }
    }
}
