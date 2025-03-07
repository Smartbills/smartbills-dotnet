namespace Smartbills.NET.Services.EmailAccounts
{
    public record EmailAccountImapUpdateRequest
    {
        public string Provider { get; set; }
        public string ImapServer { get; set; }
        public int ImapPort { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
