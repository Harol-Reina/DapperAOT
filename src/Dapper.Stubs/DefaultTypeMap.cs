using System;
using System.Reflection;

namespace Dapper;

public sealed class DefaultTypeMap : SqlMapper.ITypeMap
{
    public DefaultTypeMap(Type type) { }
    public ConstructorInfo? FindConstructor(string[] names, Type[] types) => null;
    public ConstructorInfo? FindExplicitConstructor() => null;
    public SqlMapper.IMemberMap? GetConstructorParameter(ConstructorInfo constructor, string columnName) => null;
    public SqlMapper.IMemberMap? GetMember(string columnName) => null;
}
