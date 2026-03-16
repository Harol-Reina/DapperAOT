using System;
using System.Data;

namespace Dapper;

public sealed class DbString : SqlMapper.ICustomQueryParameter
{
    public const int DefaultLength = 4000;
    public static bool IsAnsiDefault { get; set; }

    public string? Value { get; set; }
    public int Length { get; set; }
    public bool IsAnsi { get; set; }
    public bool IsFixedLength { get; set; }

    public DbString()
    {
        Length = -1;
        IsAnsi = IsAnsiDefault;
    }

    void SqlMapper.ICustomQueryParameter.AddParameter(IDbCommand command, string name)
    {
        throw new NotSupportedException("Dapper.Stubs: Use [DapperAot] attribute.");
    }
}
