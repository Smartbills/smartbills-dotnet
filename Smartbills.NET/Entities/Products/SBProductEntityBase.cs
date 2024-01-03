using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Products
{
    public interface IProductEntity : ISmartbillsEntityWithId
    {

    }
    public record SBProductEntityBase : IProductEntity
    {
        
        public long ProductId { get; set; }
        
        public long Id { get; set; }
    }
}
