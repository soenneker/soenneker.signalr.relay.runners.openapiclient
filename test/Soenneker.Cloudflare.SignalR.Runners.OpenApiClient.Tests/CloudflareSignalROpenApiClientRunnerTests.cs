using Soenneker.Tests.HostedUnit;

namespace Soenneker.Cloudflare.SignalR.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CloudflareSignalROpenApiClientRunnerTests : HostedUnitTest
{
    public CloudflareSignalROpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
