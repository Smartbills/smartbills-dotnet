using Smartbills.NET.Services.Images;

namespace Smartbills.NET.Services.Organizations
{
    public record OrganizationCreateRequest
    {
        public string Name { get; set; }
        public OrganizationBillingCreateRequest Billing { get; set; }
        public ImageUploadRequest Logo { get; set; }
    }
}
