using Smartbills.Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Smartbills.NET.Entities.Products
{
    public interface IProductEntity: ISmartbillsEntityWithId
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
