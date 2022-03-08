using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Smartbills.Client.Entities.Companies
{
    public class CreateCompanyRequest
    {
        [JsonPropertyName("slug")]
        public string Slug { get; set; }
        [JsonPropertyName("domain")]
        public string Domain { get; set; }
        [JsonPropertyName("logo")]
        public string Logo { get; set; }
        [JsonPropertyName("customer_email")]
        public string CustomerEmail { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("owner")]
        public string Owner { get; set; }
        [JsonPropertyName("hq_phone_number")]
        public string HQPhoneNumber { get; set; }
        [JsonPropertyName("hq_address")]
        public virtual SBAddress HQAddress { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
