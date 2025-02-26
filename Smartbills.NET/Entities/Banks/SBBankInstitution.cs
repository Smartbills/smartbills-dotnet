using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Banks
{
    public record SBBankInstitution : SmartbillsEntityWithId
    {
        
        public string Name { get; set; }

        
        public string Logo { get; set; }

        
        public string Products { get; set; }
        
        public string Countries { get; set; }
        
        public string Url { get; set; }
        
        public string PrimaryColor { get; set; }
    }
}
