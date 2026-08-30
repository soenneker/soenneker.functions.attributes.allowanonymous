[![](https://img.shields.io/nuget/v/soenneker.functions.attributes.allowanonymous.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.functions.attributes.allowanonymous/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.functions.attributes.allowanonymous/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.functions.attributes.allowanonymous/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.functions.attributes.allowanonymous.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.functions.attributes.allowanonymous/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.functions.attributes.allowanonymous/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.functions.attributes.allowanonymous/actions/workflows/codeql.yml)

# Soenneker.Functions.Attributes.AllowAnonymous

A marker attribute used by Soenneker's Azure Functions authentication middleware to bypass JWT authentication for a specific function entry point.

## Install

```bash
dotnet add package Soenneker.Functions.Attributes.AllowAnonymous
```

## Usage

```csharp
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Soenneker.Functions.Attributes.AllowAnonymous;

[Function("Health")]
[AllowAnonymousFunction]
public HttpResponseData Run(
    [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "health")]
    HttpRequestData request)
{
    HttpResponseData response = request.CreateResponse(System.Net.HttpStatusCode.OK);
    return response;
}
```

Apply the attribute to the same method that carries `[Function]`. The JWT middleware inspects that entry-point method and skips its authentication pipeline when the marker is present.

## Important

- This package only supplies metadata. It does not alter Azure Functions authorization or install authentication middleware by itself.
- `AuthorizationLevel.Anonymous` controls the Functions host key requirement; `[AllowAnonymousFunction]` controls the separate Soenneker JWT middleware. Public endpoints generally need both settings to permit unauthenticated requests.
- Use the marker deliberately. Any request reaching the marked function bypasses the middleware's JWT validation.
