using Smartbills.NET.Constants;
using Smartbills.NET.Entities._interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Smartbills.NET.Entities.Domains
{
    public class SBDomain: ISmartbillsEntity
    {
        [JsonPropertyName(CommonProperties.Id)]
        public long Id { get; set; }
        [JsonPropertyName("domain")]
        public string Domain { get; set; }
        [JsonPropertyName(CommonProperties.CreatedAt)]
        public string CreatedAt { get; set; }
        [JsonPropertyName("validated_at")]
        public string ValidatedAt { get; set; }
        [JsonPropertyName("is_verified")]
        public bool IsVerified { get; set; }
    }
}
