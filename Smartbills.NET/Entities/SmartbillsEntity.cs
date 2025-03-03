using Smartbills.NET.Abstractions;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities
{
    public interface ISmartbillsEntityWithId: ISmartbillsEntity
    {
    }
    public record SmartbillsEntity
    {
    }
    public record SmartbillsEntityWithId : SmartbillsEntity, ISmartbillsEntityWithId
    {
        
        public long Id { get; set; }
    }
}