namespace Smartbills.NET.Entities.Banks
{
    public enum SBBankStatus
    {
        NOT_STARTED = 0,
        SYNCHRONISING = 1,
        COMPLETED = 2,
        PENDING_EXPIRATION = 3,
        ERROR = 4,
        REVOKED = 5
    }
}
