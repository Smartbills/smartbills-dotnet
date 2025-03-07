namespace Smartbills.NET.Services
{
    public record ProductOptionCreateRequest
    {
        public string Name { get; set; }
        public string Values { get; set; }
    }
}
