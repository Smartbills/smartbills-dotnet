﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Location
{
    public record UpdateLocationRequest : BaseRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("address")]
        public CreateAddressRequest Address { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; } = true;
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
