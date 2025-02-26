using Smartbills.NET.Abstractions;
using Smartbills.NET.Constants;
using Smartbills.NET.Constants.Merchants;
using Smartbills.NET.Entities.Address;
using Smartbills.NET.Entities.Domains;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Merchants
{
    public record SBMerchant : ISmartbillsEntity
    {
        [JsonPropertyName(CommonProperties.Id)]
        public long Id { get; set; }
        [JsonPropertyName(CommonProperties.CreatedAt)]
        public DateTimeOffset CreatedAt { get; set; }
        [JsonPropertyName(CommonProperties.UpdatedAt)]
        public DateTimeOffset? UpdatedAt { get; set; }
        [JsonPropertyName(MerchantPropeties.Slug)]
        public string Slug { get; set; }
        [JsonPropertyName(MerchantPropeties.Domains)]
        public List<SBDomain> Domain { get; set; }
        [JsonPropertyName(MerchantPropeties.Logo)]
        public string Logo { get; set; }
        [JsonPropertyName(MerchantPropeties.CustomerEmail)]
        public string CustomerEmail { get; set; }
        [JsonPropertyName(MerchantPropeties.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [JsonPropertyName(MerchantPropeties.Address)]
        public SBAddress Address { get; set; }
        [JsonPropertyName(MerchantPropeties.Name)]
        public string Name { get; set; }

        [JsonPropertyName(MerchantPropeties.Locale)]
        public string Locale { get; set; }
    }
}
