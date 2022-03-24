using System;
using System.Text.Json.Serialization;

namespace Smartbills.Client.Entities
{
    public interface ISmartbillsEntityWithId
    {
        Guid Id { get;set; }
    }
    public class SmartbillsEntity
    {
    }
    public class SmartbillsEntityWithId : SmartbillsEntity, ISmartbillsEntityWithId
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
    }
}