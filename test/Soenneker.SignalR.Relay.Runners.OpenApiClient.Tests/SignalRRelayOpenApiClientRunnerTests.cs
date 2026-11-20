using Soenneker.Tests.HostedUnit;

namespace Soenneker.SignalR.Relay.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SignalRRelayOpenApiClientRunnerTests : HostedUnitTest
{
    public SignalRRelayOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
