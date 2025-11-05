
# Assessment 8 — ASP.NET Core MVC Application

This repository contains an ASP.NET Core MVC application (project file: `Assessment 8.csproj`).

## Contents

## Setup (Windows using Bash) — quick unified guide

Follow these steps to prepare your machine, install recommended VS Code tooling (optional but recommended), clone the repository, and run the app.

1) Before you begin (install these first)

- Install the .NET SDK (required): https://dotnet.microsoft.com/
- (Optional but recommended) Install Visual Studio Code: https://code.visualstudio.com/
- (Optional) Install the C# Dev Kit extension in VS Code for a great C# experience. From a terminal run:

```bash
code --install-extension ms-dotnettools.csharp-devkit
# optional: legacy OmniSharp C# extension
code --install-extension ms-dotnettools.csharp
```

Installing VS Code and the C# Dev Kit before you open the repository avoids first-run prompts and helps the extension index the project immediately.

2) Clone the repository

```bash
git clone <your-repo-url>
cd "blog-post-app-mvc"   # or rename the folder locally if you prefer
```

Note (Optional): If you want the folder to be named `Assessment 8` locally, rename it after cloning:

```bash
mv "blog-post-app-mvc" "Assessment 8"
cd "Assessment 8"
```

3) (Optional) Open in new VS Code window

```bash
code .
```

When VS Code opens, you may be asked to trust the workspace — accept to enable full extension features.

4) Install libman CLI, restore packages, build and run

```bash
# Install libman CLI globally if not already installed
dotnet tool install -g Microsoft.Web.LibraryManager.Cli
```

```bash
# Restore packages
dotnet restore "Assessment 8.csproj"
libman restore

# Build the project
dotnet build "Assessment 8.csproj" --configuration Debug

# Run the application (either of the two commands)
dotnet run
# or
dotnet run --project "Assessment 8.csproj"
```

ASP.NET will print the listening URLs (for example `http://localhost:5000` and `https://localhost:5001`) — open the HTTP URL in your browser.

5) VS Code — recommended but optional workspace settings and debugging

You can add a small `.vscode/settings.json` to the workspace to improve the experience (example):

```json
{
  "files.exclude": {
    "**/bin": true,
    "**/obj": true
  },
  "editor.formatOnSave": true,
  "csharp.format.enable": true
}
```

Debugging tips

- Set breakpoints in a controller or model, then press F5 (Run → Start Debugging).
- If VS Code prompts to add debug assets, accept — a `.vscode/launch.json` will be generated.
- If breakpoints are ignored, rebuild (`dotnet build`) and restart the debug session.

Notes & troubleshooting

- If VS Code does not detect the SDK, run `dotnet --info` in the integrated terminal to confirm the SDK is installed and on PATH.
- If static files (CSS/JS) don't load, check the browser Network tab for 404s and confirm `wwwroot/` contains the expected files. See Troubleshooting below for more details.
- If indexing or IntelliSense seems slow on first open, allow the C# Dev Kit to finish indexing the project files.

Further reading

- C# Dev Kit extension page and docs: search for "C# Dev Kit" in the VS Code marketplace or open the extension page from the Extensions view.
```bash
dotnet restore
dotnet build
dotnet run --project "Assessment 8.csproj"
```

Notes & troubleshooting

- If VS Code does not detect the SDK when you open the workspace, run `dotnet --info` in the integrated terminal to confirm the SDK is installed.
- If VS Code prompts to trust the workspace, accept so the C# Dev Kit can run necessary language features.
- If debugging asks to add debug assets when you press F5, accept — this will generate a `.vscode/launch.json` for you.
- If indexing or IntelliSense seems slow on first open, wait a moment for the C# Dev Kit to finish indexing the project files.

Further reading

- C# Dev Kit extension page and docs: search for "C# Dev Kit" in the VS Code marketplace or open the extension page from the Extensions view.

## appsettings and secrets

- Keep `appsettings.json` checked in for non-sensitive defaults.
- Ignore `appsettings.Development.json`, `appsettings.Local.json`, and any files containing secrets. Use environment variables or the ASP.NET Core Secret Manager for local secrets:

```bash
dotnet user-secrets init
dotnet user-secrets set "MySecret" "secret-value"
```

## Recommended .gitignore notes

Your repository already contains a `.gitignore`. Make sure it ignores the following (typical for ASP.NET Core MVC):

- `bin/`, `obj/` (build outputs)
- `.vs/`, `.vscode/`, `.idea/` (IDE settings)
- `appsettings.Development.json`, `appsettings.Local.json`, `secrets.json`, `.env`
- `node_modules/` (if you use Node)
- `wwwroot/lib/` (if using libman to manage client libraries)
- `publish/`, `out/`, `dist/`, `artifacts/`
- `TestResults/`, `*.trx`, `*.coverage`

Do NOT ignore `appsettings.json` if it contains defaults your app needs.

## Project structure (quick look)

- `Program.cs` — app host and pipeline
- `Controllers/` — `HomeController.cs`, `BlogController.cs`, etc.
- `Views/` — Razor views and shared layout

## Common commands

- Restore: `dotnet restore`
- Build: `dotnet build`
- Run: `dotnet run --project "Assessment 8.csproj"`
- Publish (for deployment): `dotnet publish -c Release -o ./publish`

## Troubleshooting

- If build fails, run `dotnet restore` then `dotnet build -v diag` to get verbose diagnostics.
- If ports are in use, change the launch settings in `Properties/launchSettings.json` or set the `ASPNETCORE_URLS` environment variable:

```bash
export ASPNETCORE_URLS="http://localhost:5002"
dotnet run
```

- If static files (CSS/JS) don't load, verify `wwwroot/` contents and that the `_Layout.cshtml` references the correct paths.

## Contributing

If you plan to contribute:

1. Fork or clone the repo
2. Create a feature branch
3. Add tests where relevant
4. Submit a pull request with a clear description