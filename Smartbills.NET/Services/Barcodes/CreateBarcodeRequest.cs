using Smartbills.NET.Entities;

namespace Smartbills.NET.Services
{
    public class CreateBarcodeRequest : BaseRequest
    {
        public SBBarcodeType Type { get; set; }
        public string Text { get; set; }
    }
}
