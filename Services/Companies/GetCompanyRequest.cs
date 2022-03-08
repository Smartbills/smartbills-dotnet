using System;
using Smartbills;

namespace Smartbills.Client.Services
{
    public class GetCompanyRequest : BaseRequest
    {
        public Guid CompanyId { get; set; }
    }
}