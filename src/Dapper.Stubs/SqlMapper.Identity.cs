using System;
using System.Data;

namespace Dapper;

public static partial class SqlMapper
{
    public class Identity : IEquatable<Identity>
    {
        public string Sql { get; }
        public CommandType? CommandType { get; }
        public Type? Type { get; }

        internal Identity(string sql, CommandType? commandType, IDbConnection? connection, Type? type, Type? parametersType)
        {
            Sql = sql;
            CommandType = commandType;
            Type = type;
        }

        public override int GetHashCode() => Sql?.GetHashCode() ?? 0;
        public override bool Equals(object? obj) => obj is Identity other && Equals(other);
        public bool Equals(Identity? other) => other is not null && Sql == other.Sql && CommandType == other.CommandType && Type == other.Type;

        internal Identity ForGrid(Type primaryType, int gridIndex)
            => new(Sql + $"[{gridIndex}]", CommandType, null, primaryType, null);
    }
}
