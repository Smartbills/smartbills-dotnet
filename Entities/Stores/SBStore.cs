using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Smartbills.Client.Entities.Stores
{
    public class SBStore
    {

        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        //[JsonPropertyName("address")]
        //public AddressDTO Address { get; set; }

        [JsonPropertyName("updated_at")]

        public DateTimeOffset UpdatedAt { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
        public string Name { get; set; }
        [JsonPropertyName("active")]
        public bool Active { get; set; } = true;

        [JsonPropertyName("phone_number")]
        [Phone]
        public string PhoneNumber { get; set; }
    }
}
