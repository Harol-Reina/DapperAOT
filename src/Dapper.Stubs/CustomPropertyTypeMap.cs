using System;
using System.Reflection;

namespace Dapper;

public sealed class CustomPropertyTypeMap : SqlMapper.ITypeMap
{
    public CustomPropertyTypeMap(Type type, Func<Type, string, PropertyInfo?> propertySelector) { }
    public ConstructorInfo? FindConstructor(string[] names, Type[] types) => null;
    public ConstructorInfo? FindExplicitConstructor() => null;
    public SqlMapper.IMemberMap? GetConstructorParameter(ConstructorInfo constructor, string columnName) => null;
    public SqlMapper.IMemberMap? GetMember(string columnName) => null;
}
