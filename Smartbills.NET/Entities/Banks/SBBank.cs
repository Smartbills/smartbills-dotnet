using System;
using System.Collections.Generic;
using Smartbills.NET.Abstractions;

namespace Smartbills.NET.Entities.Banks
{
    public record SBBank : SBEntity, ITimestamp, IPlaidEntity
    {
        public SBBank() : base()
        {
        }

        public SBBankInstitution Institution { get; set; }

        public DateTimeOffset ConsentExpiration { get; set; }
        public SBBankStatus Status { get; set; } = SBBankStatus.NOT_STARTED;

        public DateTimeOffset? UpdatedAt { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public List<SBBankAccount> BankAccounts { get; set; } = new();

        public long? UserId { get; set; }

        public SBBankAccountBalance Balance { get; set; }

        public string PlaidId { get; set; }
    }
}
