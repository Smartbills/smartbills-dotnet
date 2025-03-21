namespace Smartbills.NET.Entities.Emails
{
    public record SBEmailAccount : SBEntity
    {
        public string Provider { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
    }
}