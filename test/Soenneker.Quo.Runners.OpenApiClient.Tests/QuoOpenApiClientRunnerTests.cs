using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quo.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class QuoOpenApiClientRunnerTests : FixturedUnitTest
{
    public QuoOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
