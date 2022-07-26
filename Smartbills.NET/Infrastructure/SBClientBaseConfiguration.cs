namespace Smartbills.NET.Services
{
    public interface ISmartbillsClientBaseConfiguration
    {
        public const string Path = "Smartbills";
        public string Url { get; set; }

    }
}
