using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Smartbills.Client.Entities
{
    public class SBBankInstitution : SmartbillsEntityWithId
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        [JsonPropertyName("products")]
        public string Products { get; set; }
        [JsonPropertyName("countries")]
        public string Countries { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("primary_color")]
        public string PrimaryColor { get; set; }
    }
}
