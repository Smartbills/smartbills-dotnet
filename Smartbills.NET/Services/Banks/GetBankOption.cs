using Smartbills.NET.Entities.Banks;

namespace Smartbills.NET.Services.Banks
{
    public record GetBankRequest : BaseRequest
    {
        public SBBank Bank { get; set; }
    }
}