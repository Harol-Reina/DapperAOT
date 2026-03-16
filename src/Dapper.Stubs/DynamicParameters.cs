using System;
using System.Data;

namespace Dapper;

public class DynamicParameters : SqlMapper.IDynamicParameters, SqlMapper.IParameterLookup, SqlMapper.IParameterCallbacks
{
    public DynamicParameters() { }
    public DynamicParameters(object? template) { }

    void SqlMapper.IDynamicParameters.AddParameters(IDbCommand command, SqlMapper.Identity identity)
        => throw new NotSupportedException("Dapper.Stubs: Use [DapperAot] attribute.");

    object? SqlMapper.IParameterLookup.this[string name]
        => throw new NotSupportedException("Dapper.Stubs: Use [DapperAot] attribute.");

    void SqlMapper.IParameterCallbacks.OnCompleted() { }

    public void Add(string name, object? value = null, DbType? dbType = null, ParameterDirection? direction = null, int? size = null)
        => throw new NotSupportedException("Dapper.Stubs: Use [DapperAot] attribute.");

    public T? Get<T>(string name)
        => throw new NotSupportedException("Dapper.Stubs: Use [DapperAot] attribute.");
}
