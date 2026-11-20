[![](https://img.shields.io/github/actions/workflow/status/soenneker/Soenneker.Cloudflare.SignalR.Runners.OpenApiClient/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/Soenneker.Cloudflare.SignalR.Runners.OpenApiClient/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/Soenneker.Cloudflare.SignalR.Runners.OpenApiClient/daily-automatic-update.yml?style=for-the-badge&label=Daily%20Update)](https://github.com/soenneker/Soenneker.Cloudflare.SignalR.Runners.OpenApiClient/actions/workflows/daily-automatic-update.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Cloudflare.SignalR.Runners.OpenApiClient
### A runner that regenerates and updates Soenneker.Cloudflare.SignalR.OpenApiClient.

This runner executes a GitHub action that updates another project. It's not meant for consumption.

## Regenerate locally

From this repository, run:

```sh
dotnet tool restore
dotnet run --project src/Soenneker.Cloudflare.SignalR.Runners.OpenApiClient -- ../soenneker.cloudflare.signalr.openapi/openapi.json ../soenneker.cloudflare.signalr.openapiclient
```

The scheduled workflow builds and tests the regenerated client before pushing changes.
