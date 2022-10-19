using Smartbills.NET.Entities.Banks;
using Smartbills.NET.Services._base;

namespace Smartbills.NET.Services.Banks
{
    public record GetBankRequest : BaseRequest
    {
        public SBBank Bank { get; set; }
    }
}