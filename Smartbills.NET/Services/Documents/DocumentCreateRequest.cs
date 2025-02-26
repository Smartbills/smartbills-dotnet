using System;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Services.Documents
{
    public class DocumentCreateRequest
    {

        
        public long Id { get; set; }

        
        public string Name { get; set; }

        
        public string Url { get; set; }

        
        public DateTimeOffset CreatedAt { get; set; }


        
        public DateTimeOffset? UpdatedAt { get; set; }

        
        public long? UserId { get; set; }
    }
}
