# AGENTS.md

Single-project ASP.NET Core MVC app (`TaskFlowMVC.csproj`, `net10.0`). No solution file, no test projects, no CI, no lint/format config.

## Commands

- Build / verify: `dotnet build`
- Run dev server: `dotnet run` → http://localhost:5170 (https profile: 7293). Uses Development environment from `Properties/launchSettings.json`.
- Docker image binds port **10000** via `ASPNETCORE_URLS` (deployed to Render). Don't change ports in `Dockerfile` without considering the host platform config.

## Architecture gotchas

- **No persistence layer.** All tasks live in a `static List<TaskItem>` inside `Controllers/TasksController.cs`. Data resets on every restart/process recycle. Adding a DB means introducing EF Core or similar — there is no DbContext anywhere yet.
- IDs are assigned manually in `TasksController.Create` (`Max(Id) + 1`) since there's no backing store.
- Standard MVC layout: `Controllers/`, `Models/`, `Views/{Home,Tasks,Shared}`. Routes use the default `{controller}/{action}/{id?}` pattern; entry point is `Program.cs` (minimal hosting).

## Conventions

- User-facing strings (validation messages, TempData flash messages) are in **Spanish** — match that.
- All mutating POST actions require `[ValidateAntiForgeryToken]`; corresponding `.cshtml` forms must include the antiforgery token.
- `<Nullable>enable</Nullable>` and implicit usings are on — follow existing null-handling patterns.
