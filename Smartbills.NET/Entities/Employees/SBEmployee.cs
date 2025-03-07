
using System;

namespace Smartbills.NET.Entities.Employees
{
    public record SBEmployee : SBEntity, ITimestamp
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? Birthdate { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
