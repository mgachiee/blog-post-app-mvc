
# Assessment 8 — ASP.NET Core MVC Application

This repository contains an ASP.NET Core MVC application (project file: `Assessment 8.csproj`).

## Contents

- `Controllers/` — MVC controllers
- `Models/` — model classes
- `Views/` — Razor views
- `wwwroot/` — static files (CSS, JS, libs)
- `appsettings.json` — tracked configuration (do not store secrets here)
- `appsettings.Development.json` — local development config (should be ignored)

## Overview

This is a standard ASP.NET Core MVC app targeting .NET 9.0 (project assets reference `net9.0`). Use the .NET SDK to build and run locally.

## Prerequisites

- .NET SDK 9.0 (or compatible runtime shown in the project). Install from https://dotnet.microsoft.com/
- Optional: Visual Studio / VS Code / Rider for development
- Optional: Node.js/npm if you modify frontend packages

## Setup (Windows using Bash)

1. Clone the repository (if you haven't already):

```bash
git clone <your-repo-url>
cd "Assessment 8"
```

2. Restore NuGet packages:

```bash
dotnet restore
```

3. Build the project:

```bash
dotnet build --configuration Debug
```

4. Run the app:

```bash
dotnet run --project "Assessment 8.csproj"
```

By default, ASP.NET will print the listening URLs to the console (usually `http://localhost:5000` and `https://localhost:5001`). Open the URL in your browser.

## VS Code — C# Dev Kit setup (recommended)

If you use Visual Studio Code, the C# Dev Kit extension provides a focused, integrated experience for C#/.NET development (project navigation, debugging, test explorer, quick fixes and code actions). Follow these steps to set up VS Code for this repository.

Prerequisites

- VS Code (stable) installed: https://code.visualstudio.com/
- .NET SDK installed (see earlier 'Prerequisites' section)

Install the extension

You can install the C# Dev Kit extension from the Extensions view in VS Code or via the command line:

```bash
code --install-extension ms-dotnettools.csharp-devkit
# optional: install the legacy OmniSharp C# extension if you prefer or need it
code --install-extension ms-dotnettools.csharp
```

Open the project folder

1. Open this repository folder in VS Code (File → Open Folder or from the terminal):

```bash
code .
```

2. When prompted, trust the workspace so extensions can run. Allow the C# Dev Kit to index the project; this improves navigation and the in-editor experience.

Restore, build and run from VS Code

- Use the integrated terminal (View → Terminal) and run:

```bash
dotnet restore
dotnet build
dotnet run --project "Assessment 8.csproj"
```

Debugging

- Set breakpoints in a controller or view model.
- Press F5 (or Run → Start Debugging). If VS Code asks to add required debug assets, accept — a `launch.json` will be created under `.vscode/`.
- The C# Dev Kit provides a Debug view with controls to step, inspect variables and view locals.

Recommended workspace settings (optional)

Add a small `.vscode/settings.json` to the workspace to improve the experience (example):

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

Tips & troubleshooting

- If VS Code does not detect the SDK, confirm `dotnet --info` in the integrated terminal prints the expected SDK.
- If debugging doesn't attach or breakpoints are ignored, try rebuilding (`dotnet build`) and restart the debug session.
- If code navigation or intellisense feels slow, make sure C# Dev Kit indexing has completed and allow the extension time to initialize.

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

1. Fork the repo
2. Create a feature branch
3. Add tests where relevant
4. Submit a pull request with a clear description