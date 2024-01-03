using Smartbills.NET.Abstractions;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.BankInstitutions
{
    public record BankInstitutionUpdateRequest : BaseRequest, IPlaidEntity
    {
        
        public string Name { get; set; }

        
        public string Logo { get; set; }

        
        public string Products { get; set; }
        
        public string Countries { get; set; }
        
        public string Url { get; set; }
        
        public string PrimaryColor { get; set; }
        
        public string PlaidId { get; set; }
    }
}