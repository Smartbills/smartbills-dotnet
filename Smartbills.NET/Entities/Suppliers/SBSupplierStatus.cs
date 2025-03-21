namespace Smartbills.NET.Entities.Suppliers
{
    public enum SBSupplierStatus
    {
        New = 0,
        Connecting = 1,
        CredentialsSent = 2,
        InvalidCredentials = 3,
        ConnectedCredentials = 4,
        SecurityQuestion = 5,
        MfaQuestion = 6,
        MfaQuestionNoAnswer = 7,
        Captcha = 8,
        AccountSelection = 9,
        RetryLater = 10,
        ConnectedWithData = 11,
        ConnectedWaitingOnDataExtraction = 12,
        ConnectedButNoDataFound = 13,
        Error = 14
    }
}