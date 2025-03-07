namespace Smartbills.NET.Services.Integrations
{
    public class IntegrationCreateRequest
    {
        public string ApplicationSlug { get; set; }
        public string ExternalId { get; set; }
        public string Configuration { get; set; }
    }
}
