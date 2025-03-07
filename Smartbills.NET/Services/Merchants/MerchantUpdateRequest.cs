﻿using Smartbills.NET.Entities.Address;

namespace Smartbills.NET.Services
{
    public record MerchantUpdateRequest
    {
        public string Name { get; set; }
        public SBAddress Address { get; set; }
        public string Logo { get; set; }
        public string Timezone { get; set; }
        public string Currency { get; set; }
        public string Website { get; set; }
        public string PhoneNumber { get; set; }
        public string Locale { get; set; }
    }
}
