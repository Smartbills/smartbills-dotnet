using System;
using System.Text.Json.Serialization;

namespace Smartbills.Client.Entities
{
    public class SmartbillsEntity
    {
    }
    public class SmartbillsEntityWithId : SmartbillsEntity
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
    }
}