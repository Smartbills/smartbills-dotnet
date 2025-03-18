namespace Smartbills.NET.Services.Merchants.Customers
{
    public record CustomerListRequest : ListRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AccountNumber { get; set; }
        public string CustomerNumber { get; set; }
    }

}
