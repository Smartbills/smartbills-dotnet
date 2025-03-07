using Smartbills.NET.Entities.Address;

namespace Smartbills.NET.Services.Organizations
{
    public record OrganizationBillingCreateRequest
    {
        public string Email { get; set; }
        public SBBillingAddress BillingAddress { get; set; }
        public string Locale { get; set; }
    }
}