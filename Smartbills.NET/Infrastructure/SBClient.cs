using System;
using System.Threading.Tasks;
using IdentityModel.Client;
using Microsoft.Extensions.Options;
using RestSharp;
using RestSharp.Authenticators;
using Smartbills.Client;
using Smartbills.NET.Services;
using static System.Net.Mime.MediaTypeNames;
namespace Smarbtills.NET.Services
{
    public interface ISmartbillsClient : ISBBaseClient
    {
    }
    public class SmartbillsClient : SBBaseClient, ISmartbillsClient
    {
        public SmartbillsClient(IOptions<SBClientConfiguration> configuration, IOptions<SBClientCredential> credentials) : base(configuration, credentials)
        {
        }

    }

}