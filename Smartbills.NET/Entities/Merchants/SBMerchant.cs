using Smartbills.NET.Constants;
using Smartbills.NET.Constants.Merchants;
using Smartbills.NET.Entities.Domains;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities
{
    public class SBMerchant: ISmartbillsEntity
    {
        [JsonPropertyName(CommonProperties.ID)]
        public long Id { get; set; }
        [JsonPropertyName(CommonProperties.CREATED_AT)]
        public DateTimeOffset CreatedAt { get; set; }
        [JsonPropertyName(CommonProperties.UPDATED_AT)]
        public DateTimeOffset UpdatedAt { get; set; }
        [JsonPropertyName(MerchantPropeties.SLUG)]
        public string Slug { get; set; }
        [JsonPropertyName(MerchantPropeties.DOMAINS)]
        public List<SBDomain> Domain { get; set; }
        [JsonPropertyName(MerchantPropeties.LOGO)]
        public string Logo { get; set; }
        [JsonPropertyName(MerchantPropeties.CUSTOMER_EMAIL)]
        public string CustomerEmail { get; set; }
        [JsonPropertyName(MerchantPropeties.PHONE_NUMBER)]
        public string PhoneNumber { get; set; }
        [JsonPropertyName(MerchantPropeties.ADDRESS)]
        public SBAddress Address { get; set; }
        [JsonPropertyName(MerchantPropeties.NAME)]
        public string Name { get; set; }
    }
}
