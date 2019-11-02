using System.Threading.Tasks;
using RetireNet.Packages.Tool.Services;
using Xunit;

namespace DotNetRetire.Tests
{
    public class ResourceReaderTests
    {
        [Fact]
        public async Task TestReader()
        {
            var resourceReader = new ResourceReader();
            var overrides = await resourceReader.GetOverriddenPackages();
            Assert.NotNull(overrides);
        }
    }
}
