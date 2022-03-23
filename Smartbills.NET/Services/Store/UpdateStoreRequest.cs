using Smartbills.Client.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Smartbills.Client.Services.Store
{
    public class UpdateStoreRequest: BaseRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        //[JsonPropertyName("address")]
        //public UpdateAddressRequest Address { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; } = true;
        [Phone]
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
