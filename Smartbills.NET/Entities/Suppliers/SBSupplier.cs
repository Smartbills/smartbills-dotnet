using System;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Suppliers
{
    public record SBSupplier : SBEntity, ITimestamp
    {
        public string Username { get; set; }
        public string SourceName { get; set; }
        public string SourceLogo { get; set; }
        public string SourceId { get; set; }
        public string ConnectionId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? OrganizationId { get; set; }
        public long? UserId { get; set; }
        public SBSupplierStatus Status { get; set; }
        public DateTimeOffset? FirstSuccessfulConnection { get; set; }
        public DateTimeOffset? LastSuccessfulConnection { get; set; }
        public DateTimeOffset? LastFailedConnection { get; set; }
        public DateTimeOffset? LastWebhook { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}