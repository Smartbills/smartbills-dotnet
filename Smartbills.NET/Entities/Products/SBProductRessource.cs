using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Products
{
    public class SBProductRessource
    {
        [JsonPropertyName("product_id")]
        public long ProductId { get; set; }
    }
}
