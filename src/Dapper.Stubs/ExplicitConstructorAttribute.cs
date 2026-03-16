using System;

namespace Dapper;

[AttributeUsage(AttributeTargets.Constructor)]
public sealed class ExplicitConstructorAttribute : Attribute
{
}
