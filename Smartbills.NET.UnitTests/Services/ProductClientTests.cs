using Smartbills.NET.Infrastructure;
using Smartbills.NET.Services.Products;
using System.Threading.Tasks;
using Xunit;

namespace Smartbills.NET.UnitTests.Services
{
    public class ProductClientTests
    {

        public ProductClientTests()
        {
        }

        [Fact]
        public async Task CreateProduct()
        {

            var productClient = new ProductClient(123, new SBClientCredentials()
            {
                Authority = "http://192.168.0.198:5002",
                ClientId = "smartbills-square",
                Scopes = new string[] { "locations:create", "locations:update", "receipts:update", "receipts:create", "merchants:create", "merchants:update", "customers:update", "customers:create" },
            }, "https://localhost:44305");
            await productClient.CreateAsync(new CreateProductRequest() { });

        }
    }
}
