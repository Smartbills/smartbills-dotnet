

using Smartbills.NET.Entities;

namespace Smartbills.NET.Services.Customers
{
    public record CustomerBatchUpdateRequest : CustomerUpdateRequest, ISBEntity
    {
        public long Id { get; set; }
    }
}
