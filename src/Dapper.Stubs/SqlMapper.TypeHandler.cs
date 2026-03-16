using System;
using System.Data;

namespace Dapper;

public static partial class SqlMapper
{
    public abstract class TypeHandler<T> : ITypeHandler
    {
        public abstract void SetValue(IDbDataParameter parameter, T? value);
        public abstract T? Parse(object value);

        void ITypeHandler.SetValue(IDbDataParameter parameter, object? value)
            => SetValue(parameter, (value is DBNull) ? default : (T?)value);

        object? ITypeHandler.Parse(Type destinationType, object value) => Parse(value);
    }
}
