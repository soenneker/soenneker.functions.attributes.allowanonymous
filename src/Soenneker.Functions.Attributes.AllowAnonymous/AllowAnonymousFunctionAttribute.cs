using System;

namespace Soenneker.Functions.Attributes.AllowAnonymous;

/// <summary>
/// Marks an Azure Functions entry-point method so compatible Soenneker authentication middleware can bypass JWT validation for that function.
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class AllowAnonymousFunctionAttribute : Attribute;
