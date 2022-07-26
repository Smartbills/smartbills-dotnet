using Smartbills.NET.Entities;

namespace Smartbills.NET.Services
{
    public record CreateBarcodeRequest : BaseRequest
    {
        public SBBarcodeType Type { get; set; }
        public string Text { get; set; }
    }
}
