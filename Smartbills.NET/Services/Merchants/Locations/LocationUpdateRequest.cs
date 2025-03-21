using Smartbills.NET.Entities.Address;
using Smartbills.NET.Services.Images;
using System.Collections.Generic;

namespace Smartbills.NET.Services.Merchants.Locations
{
    public record LocationUpdateRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public SBAddress Address { get; set; }

        public string MerchantCategoryCode { get; set; }
        public string Currency { get; set; }
        public string Timezone { get; set; }

        public string PhoneNumber { get; set; }

        public string Website { get; set; }


        public string FacebookUrl { get; set; }
        public string InstagramUsername { get; set; }

        public string TwitterUsername { get; set; }

        public bool IsActive { get; set; } = true;

        public string Locale { get; set; }

        public string Email { get; set; }

        public string Logo { get; set; }
        public List<ImageUploadRequest> Images { get; set; } = new List<ImageUploadRequest>();
    }
}
