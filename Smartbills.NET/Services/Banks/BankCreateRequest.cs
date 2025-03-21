using Smartbills.NET.Services.Banks.BankAccounts;
using System;
using System.Collections.Generic;

namespace Smartbills.NET.Services.Banks
{
    public record BankCreateRequest
    {
        public string PublicToken { get; set; }

        public string LinkSessionId { get; set; }

        public string InstitutionId { get; set; }

        public List<BankAccountCreateRequest> Accounts { get; set; } = new();

        public DateTimeOffset? ConsentExpiration { get; set; }

    }
}
