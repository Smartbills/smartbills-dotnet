using System;

namespace Smartbills.NET.Entities
{
    public interface ITimestamp
    {
        DateTimeOffset CreatedAt { get; set; }
        DateTimeOffset? UpdatedAt { get; set; }
    }
}