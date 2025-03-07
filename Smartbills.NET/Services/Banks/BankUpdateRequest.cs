using Smartbills.NET.Abstractions;
using System;
using System.Collections.Generic;

namespace Smartbills.NET.Services
{
    public record BankUpdateRequest : IPlaidEntity
    {
        public DateTimeOffset ConsentExpiration { get; set; }
        //public BankState State { get; set; } = BankState.NOT_STARTED;
        public List<BankAccountUpdateRequest> BankAccounts { get; set; } = new();
        public string PlaidId { get; set; }
    }
}
