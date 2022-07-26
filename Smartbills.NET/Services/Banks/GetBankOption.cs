using Smartbills.NET.Entities;

namespace Smartbills.NET.Services
{
    public record GetBankRequest : BaseRequest
    {
        public SBBank Bank { get; set; }
    }
}