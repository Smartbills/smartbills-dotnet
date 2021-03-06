using System;
using System.Text.Json.Serialization;

namespace Smartbills.Client.Entities
{
    public class CreateProductVariantDTO
    {

        [JsonPropertyName("initial_price")]
        public decimal? InitialPrice { get; set; }
        [JsonPropertyName("price")]
        public decimal Price { get; set; }
        // public List<SBProductVariantOption> Request { get; set; }

        [JsonPropertyName("weight_unit")]
        public string WeightUnit { get; set; }
        [JsonPropertyName("weight")]
        public decimal Weight { get; set; }

        [JsonPropertyName("taxable")]
        public bool Taxable { get; set; }
        [JsonPropertyName("position")]
        public string Name { get; set; }
        [JsonPropertyName("image_id")]
        public Guid? ImageId { get; set; }
        [JsonPropertyName("barcode")]
        public string Barcode { get; set; }
        [JsonPropertyName("sku")]
        public string Sku { get; set; }
    }
}
