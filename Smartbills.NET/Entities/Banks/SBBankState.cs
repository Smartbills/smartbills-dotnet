namespace Smartbills.NET.Entities.Banks
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
