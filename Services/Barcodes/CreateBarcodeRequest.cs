using Smartbills.Client.Entities;

namespace Smartbills.Client.Services
{
    public class CreateBarcodeRequest : BaseRequest
    {
        public SBBarcodeType Type { get; set; }
        public string Text { get; set; }
    }
}
