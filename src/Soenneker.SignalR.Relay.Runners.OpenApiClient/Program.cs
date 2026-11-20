using System;
using System.Diagnostics;
using System.IO;

const string library = "Soenneker.SignalR.Relay.OpenApiClient";
if (args.Length != 2) throw new ArgumentException("Supply openapi.json and the generated client repository directory.");
var document = Path.GetFullPath(args[0]);
var project = Path.Combine(Path.GetFullPath(args[1]), "src", library);
if (!File.Exists(document) || !File.Exists(Path.Combine(project, library + ".csproj")))
    throw new ArgumentException("The spec and client project must exist.");

// The lock file records the relative spec path. Keep the same layout in CI and local builds.
File.Copy(document, Path.Combine(project, "openapi.json"), overwrite: true);
var start = new ProcessStartInfo("dotnet") { UseShellExecute = false };
foreach (string argument in new[] { "tool", "run", "kiota", "--", "generate", "--language", "CSharp",
    "--openapi", Path.Combine(project, "openapi.json"), "--namespace-name", library,
    "--class-name", "SignalRRelayOpenApiClient", "--output", Path.Combine(project, "Generated"),
    "--exclude-backward-compatible", "--clean-output" })
    start.ArgumentList.Add(argument);
using var generator = Process.Start(start) ?? throw new InvalidOperationException("Unable to start Kiota.");
await generator.WaitForExitAsync();
return generator.ExitCode;
