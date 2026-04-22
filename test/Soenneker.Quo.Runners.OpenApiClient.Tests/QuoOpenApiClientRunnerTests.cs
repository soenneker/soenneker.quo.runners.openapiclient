using Soenneker.Tests.HostedUnit;

namespace Soenneker.Quo.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class QuoOpenApiClientRunnerTests : HostedUnitTest
{
    public QuoOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
