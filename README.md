[![](https://img.shields.io/github/actions/workflow/status/soenneker/Soenneker.SignalR.Relay.Runners.OpenApiClient/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/Soenneker.SignalR.Relay.Runners.OpenApiClient/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/Soenneker.SignalR.Relay.Runners.OpenApiClient/daily-automatic-update.yml?style=for-the-badge&label=Daily%20Update)](https://github.com/soenneker/Soenneker.SignalR.Relay.Runners.OpenApiClient/actions/workflows/daily-automatic-update.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.SignalR.Relay.Runners.OpenApiClient
### A runner that regenerates and updates Soenneker.SignalR.Relay.OpenApiClient.

This runner executes a GitHub action that updates another project. It's not meant for consumption.

## Regenerate locally

From this repository, run:

```sh
dotnet tool restore
dotnet run --project src/Soenneker.SignalR.Relay.Runners.OpenApiClient -- ../soenneker.signalr.relay.openapi/openapi.json ../soenneker.signalr.relay.openapiclient
```

The scheduled workflow builds and tests the regenerated client before pushing changes.
