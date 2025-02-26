using Smartbills.NET.Abstractions;
using Smartbills.NET.Services.BankBalances;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.BankAccounts
{
    public record BankAccountCreateRequest : BaseRequest, IPlaidEntity
    {

        
        public string Type { get; set; }
        
        public string SubType { get; set; }
        
        public string Name { get; set; }
        
        public string Mask { get; set; }
        
        public string OfficialName { get; set; }
        
        public BankBalanceCreateRequest Balance { get; set; }
        
        public string PlaidId { get; set; }

    }
}