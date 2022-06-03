using Smartbills.NET.Entities;

namespace Smartbills.NET.Services
{
    public class GetBankRequest : BaseRequest
    {
        public SBBank Bank { get; set; }
    }
}