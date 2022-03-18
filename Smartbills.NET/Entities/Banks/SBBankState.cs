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
