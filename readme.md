# BlazorLogin

Proyecto de ejemplo creado manualmente siguiendo la plantilla de **Blazor Server** para .NET 8.0.

## Estructura

- `BlazorLogin.sln`: solución de Visual Studio que incluye el proyecto principal.
- `BlazorLogin/`: proyecto Blazor Server (`net8.0`).
  - `Program.cs`: configuración de servicios y pipeline HTTP.
  - `Components/`: componentes Razor, páginas y diseño principal.
  - `Data/`: servicios y modelos de ejemplo (pronóstico del tiempo).
  - `Pages/_Host.cshtml`: punto de entrada para la aplicación Blazor Server.
  - `wwwroot/`: archivos estáticos (CSS, favicon, etc.).

## Requisitos

- SDK de .NET 8.0 o superior.

## Ejecución

```bash
cd BlazorLogin
dotnet restore
dotnet run
```

La aplicación se iniciará en las URL configuradas dentro de `launchSettings.json`.
