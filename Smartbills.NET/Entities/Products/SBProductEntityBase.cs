using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Products
{
    public interface IProductEntity : ISmartbillsEntityWithId
    {

    }
    public class SBProductEntityBase : IProductEntity
    {
        [JsonPropertyName("product_id")]
        public long ProductId { get; set; }
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
