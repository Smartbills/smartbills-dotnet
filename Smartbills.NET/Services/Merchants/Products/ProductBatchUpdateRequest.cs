using Smartbills.NET.Entities;

namespace Smartbills.NET.Services.Merchants.Products
{
    public record ProductBatchUpdateRequest : ProductUpdateRequest, ISBEntity
    {
        public long Id { get; set; }
    }
}
