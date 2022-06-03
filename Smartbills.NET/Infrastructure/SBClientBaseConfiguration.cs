namespace Smartbills.NET.Services
{
    public interface ISBClientBaseConfiguration
    {
        public const string Path = "Smartbills";
        public string Url { get; set; }

    }
}
