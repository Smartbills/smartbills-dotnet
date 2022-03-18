using Smartbills.Client.Entities;

namespace Smartbills.Client.Services
{
    public class GetBankRequest : BaseRequest
    {
        public SBBank Bank { get; set; }
    }
}