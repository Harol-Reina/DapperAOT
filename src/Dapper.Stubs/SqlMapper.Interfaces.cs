using System;
using System.Data;
using System.Reflection;

namespace Dapper;

public static partial class SqlMapper
{
    public interface ICustomQueryParameter
    {
        void AddParameter(IDbCommand command, string name);
    }

    public interface IDynamicParameters
    {
        void AddParameters(IDbCommand command, Identity identity);
    }

    public interface IParameterLookup : IDynamicParameters
    {
        object? this[string name] { get; }
    }

    public interface IParameterCallbacks : IDynamicParameters
    {
        void OnCompleted();
    }

    public interface ITypeHandler
    {
        void SetValue(IDbDataParameter parameter, object? value);
        object? Parse(Type destinationType, object value);
    }

    public interface ITypeMap
    {
        ConstructorInfo? FindConstructor(string[] names, Type[] types);
        ConstructorInfo? FindExplicitConstructor();
        IMemberMap? GetConstructorParameter(ConstructorInfo constructor, string columnName);
        IMemberMap? GetMember(string columnName);
    }

    public interface IMemberMap
    {
        string ColumnName { get; }
        Type MemberType { get; }
        PropertyInfo? Property { get; }
        FieldInfo? Field { get; }
        ParameterInfo? Parameter { get; }
    }
}
