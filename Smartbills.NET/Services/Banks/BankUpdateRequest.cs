using Smartbills.NET.Abstractions;
using Smartbills.NET.Services.Banks.BankAccounts;
using System;
using System.Collections.Generic;

namespace Smartbills.NET.Services.Banks
{
    public record BankUpdateRequest : IPlaidEntity
    {
        public DateTimeOffset ConsentExpiration { get; set; }
        //public BankState State { get; set; } = BankState.NOT_STARTED;
        public List<BankAccountUpdateRequest> BankAccounts { get; set; } = new();
        public string PlaidId { get; set; }
    }
}
