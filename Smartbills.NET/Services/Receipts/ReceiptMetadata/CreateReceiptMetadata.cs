namespace Smartbills.NET.Services.Receipts.ReceiptMetadata
{
    public record ReceiptMetadataCreateRequest
    {

        public string LandingSite { get; set; }
        public string CustomerLocale { get; set; }

        public string RefferingSite { get; set; }

        public string SourcePOS { get; set; }

        public string SourceName { get; set; }
        public string Tags { get; set; }
        public string Url { get; set; }
        public CreateBrowserMetadataDTO BrowserMetadata { get; set; }
    }
}
