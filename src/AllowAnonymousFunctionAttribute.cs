using System;

namespace Soenneker.Functions.Attributes.AllowAnonymous;

/// <summary>
/// An attribute for excluding authentication for Azure functions
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class AllowAnonymousFunctionAttribute : Attribute;