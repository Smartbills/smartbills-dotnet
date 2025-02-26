namespace Smartbills.NET.Infrastructure
{
    public interface ISmartbillsClientBaseConfiguration
    {
        public const string Path = "Smartbills";
        public string Url { get; set; }

    }
}
