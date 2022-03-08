using System;
using System.Collections.Generic;
using System.Text;

namespace Smartbills.Client.Entities
{
    public enum SBBankState
    {
        NOT_STARTED,
        SYNCHRONISING,
        COMPLETED,
        PENDING_EXPIRATION,
        ERROR,
        REVOKED
    }
}
