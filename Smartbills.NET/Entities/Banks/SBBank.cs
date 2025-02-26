using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Smartbills.NET.Entities.Banks
{
    public record SBBank : SmartbillsEntityWithId
    {
        public SBBank() : base()
        {
        }

        
        public SBBankInstitution Institution { get; set; }

        
        public DateTimeOffset ConsentExpiration { get; set; }
        public SBBankState State { get; set; } = SBBankState.NOT_STARTED;

        
        public DateTimeOffset? UpdatedAt { get; set; }

        
        public DateTimeOffset CreatedAt { get; set; }

        
        public List<SBBankAccount> BankAccounts { get; set; } = new();

    }
}
