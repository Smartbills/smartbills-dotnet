using Smartbills.NET.Abstractions;
using Smartbills.NET.Constants;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Domains
{
    public record SBDomain : ISmartbillsEntity
    {
        public long Id { get; set; }
        
        public string Domain { get; set; }
        public string CreatedAt { get; set; }
        
        public string ValidatedAt { get; set; }
        
        public bool IsVerified { get; set; }
    }
}
