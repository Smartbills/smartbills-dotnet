namespace Smartbills.NET.Services
{
    public record ProductOptionUpdateRequest
    {
        public string Name { get; set; }
        public string Values { get; set; }
    }
}
