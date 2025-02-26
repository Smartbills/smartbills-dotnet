using Smartbills.NET.Abstractions;
using System;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Documents
{
    public record SBDocument: ISmartbillsEntity
    {

        
        public long Id { get; set; }

        
        public string Name { get; set; }

        
        public string Url { get; set; }

        
        public DateTimeOffset CreatedAt { get; set; }


        
        public DateTimeOffset? UpdatedAt { get; set; }

        
        public long? UserId { get; set; }
    }
}
