using Smartbills.NET.Entities.Address;
using Smartbills.NET.Services.Images;

namespace Smartbills.NET.Services
{
    public record MerchantCreateRequest
    {
        public required string Name { get; set; }

        public required SBAddress Address { get; set; }
        public ImageUploadRequest Logo { get; set; }
        public string Timezone { get; set; }
        public string Currency { get; set; }
        public string Website { get; set; }
        public string PhoneNumber { get; set; }
        public string Locale { get; set; } = "en";
    }
}
