using Xunit;

namespace Smartbills.NET.IntegrationTests
{
    [CollectionDefinition("ClientFixture")]
    public class ClientCollection : ICollectionFixture<ClientFixture>
    {
    }
}
