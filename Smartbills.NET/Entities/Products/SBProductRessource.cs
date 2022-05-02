using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Smartbills.NET.Entities
{
    public class SBProductRessource
    {
        [JsonPropertyName("product_id")]
        public long ProductId { get; set; }
    }
}
