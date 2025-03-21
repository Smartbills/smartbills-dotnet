
using System;
using System.Collections.Generic;
using Smartbills.NET.Entities;

namespace Smartbills.NET.Entities.Products.Modifiers
{
    public record SBProductModifierGroupResponse : SBEntity, ITimestamp
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Required { get; set; }
        public int MinimumSelection { get; set; }
        public int MaximumSelection { get; set; }
        public bool Active { get; set; }
        public int DisplayOrder { get; set; }
        public List<SBProductModifier> Modifiers { get; set; } = new();
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}