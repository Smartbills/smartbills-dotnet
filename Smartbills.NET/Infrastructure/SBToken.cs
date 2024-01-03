using Smartbills.NET.Abstractions;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Infrastructure
{
    public record SBToken
    {
        
        public string AccessToken { get; set; }
        
        public string RefreshToken { get; set; }
        
        public int ExpiresIn { get; set; } = 0;
        
        public string TokenType { get; set; }
        
        public string Scope { get; set; }

    }
}
