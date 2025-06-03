namespace Smartbills.NET.Services.Taxes
{
    public record TaxUpsertRequest : TaxCreateRequest, IUpsertRequest
    {
        public long? Id { get; set; }
    }
}
