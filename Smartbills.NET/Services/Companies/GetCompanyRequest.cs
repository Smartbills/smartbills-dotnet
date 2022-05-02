using System;

namespace Smartbills.Client.Services
{
    public class GetCompanyRequest : BaseRequest
    {
        public long CompanyId { get; set; }
    }
}