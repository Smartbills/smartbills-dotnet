using Microsoft.Extensions.Options;
using Smartbills.NET;
using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services;
namespace Smarbtills.NET.Services
{
    public interface ISBClient : ISBBaseClient
    {
    }
    public class SBClient : SBBaseClient, ISBClient
    {
        public SBClient(IOptions<SBClientConfiguration> configuration, IOptions<SBClientCredential> credentials) : base(configuration, credentials)
        {
        }
    }

}