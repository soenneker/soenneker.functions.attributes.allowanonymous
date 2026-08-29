[![](https://img.shields.io/nuget/v/soenneker.functions.attributes.allowanonymous.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.functions.attributes.allowanonymous/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.functions.attributes.allowanonymous/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.functions.attributes.allowanonymous/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.functions.attributes.allowanonymous.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.functions.attributes.allowanonymous/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.functions.attributes.allowanonymous/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.functions.attributes.allowanonymous/actions/workflows/codeql.yml)

# Soenneker.Functions.Attributes.AllowAnonymous

An attribute for excluding authentication for Azure functions.

## Install

```bash
dotnet add package Soenneker.Functions.Attributes.AllowAnonymous
```

## Quick start

```csharp
using Soenneker.Functions.Attributes.AllowAnonymous;

[AllowAnonymousFunction]
public void HandleRequest()
{
    // This method now carries the marker metadata.
}
```

An attribute for excluding authentication for Azure functions.

## What you get

- `AllowAnonymousFunctionAttribute` — An attribute for excluding authentication for Azure functions.
