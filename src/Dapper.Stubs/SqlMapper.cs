using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace Dapper;

public static partial class SqlMapper
{
    private const string M = "Dapper.Stubs: Use [DapperAot] for AOT compilation";
    private static NotSupportedException Nope() => new(M);

    // Fields/Properties/Events
    public static Func<Type, ITypeMap> TypeMapProvider = t => new DefaultTypeMap(t);
    public static IEqualityComparer<string> ConnectionStringComparer { get => StringComparer.Ordinal; set { } }
    public static event EventHandler? QueryCachePurged;

    // Nested type
    public static class TypeHandlerCache<T>
    {
        public static T? Parse(object value) => throw Nope();
        public static void SetValue(IDbDataParameter parameter, object value) => throw Nope();
    }

    // ── Query sync - dynamic ──

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IEnumerable<dynamic> Query(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static dynamic QueryFirst(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static dynamic? QueryFirstOrDefault(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static dynamic QuerySingle(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static dynamic? QuerySingleOrDefault(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    // ── Query sync - generic ──

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IEnumerable<T> Query<T>(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static T QueryFirst<T>(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static T? QueryFirstOrDefault<T>(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static T QuerySingle<T>(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static T? QuerySingleOrDefault<T>(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    // ── Query sync - Type ──

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IEnumerable<object> Query(this IDbConnection cnn, Type type, string sql, object? param = null, IDbTransaction? transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static object QueryFirst(this IDbConnection cnn, Type type, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static object? QueryFirstOrDefault(this IDbConnection cnn, Type type, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static object QuerySingle(this IDbConnection cnn, Type type, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static object? QuerySingleOrDefault(this IDbConnection cnn, Type type, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    // ── Query sync - CommandDefinition ──

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IEnumerable<T> Query<T>(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static T QueryFirst<T>(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static T? QueryFirstOrDefault<T>(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static T QuerySingle<T>(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static T? QuerySingleOrDefault<T>(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    // ── QueryAsync - dynamic ──

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IEnumerable<dynamic>> QueryAsync(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IEnumerable<dynamic>> QueryAsync(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<dynamic> QueryFirstAsync(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<dynamic?> QueryFirstOrDefaultAsync(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<dynamic> QuerySingleAsync(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<dynamic?> QuerySingleOrDefaultAsync(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<dynamic> QueryFirstAsync(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<dynamic?> QueryFirstOrDefaultAsync(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<dynamic> QuerySingleAsync(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<dynamic?> QuerySingleOrDefaultAsync(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    // ── QueryAsync - generic ──

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IEnumerable<T>> QueryAsync<T>(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<T> QueryFirstAsync<T>(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<T?> QueryFirstOrDefaultAsync<T>(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<T> QuerySingleAsync<T>(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<T?> QuerySingleOrDefaultAsync<T>(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IEnumerable<T>> QueryAsync<T>(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<T> QueryFirstAsync<T>(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<T?> QueryFirstOrDefaultAsync<T>(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<T> QuerySingleAsync<T>(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<T?> QuerySingleOrDefaultAsync<T>(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    // ── QueryAsync - Type ──

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IEnumerable<object>> QueryAsync(this IDbConnection cnn, Type type, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<object> QueryFirstAsync(this IDbConnection cnn, Type type, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<object?> QueryFirstOrDefaultAsync(this IDbConnection cnn, Type type, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<object> QuerySingleAsync(this IDbConnection cnn, Type type, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<object?> QuerySingleOrDefaultAsync(this IDbConnection cnn, Type type, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IEnumerable<object>> QueryAsync(this IDbConnection cnn, Type type, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<object> QueryFirstAsync(this IDbConnection cnn, Type type, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<object?> QueryFirstOrDefaultAsync(this IDbConnection cnn, Type type, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<object> QuerySingleAsync(this IDbConnection cnn, Type type, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<object?> QuerySingleOrDefaultAsync(this IDbConnection cnn, Type type, CommandDefinition command)
        => throw Nope();

    // ── QueryUnbufferedAsync ──

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IAsyncEnumerable<dynamic> QueryUnbufferedAsync(this DbConnection cnn, string sql, object? param = null, DbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IAsyncEnumerable<T> QueryUnbufferedAsync<T>(this DbConnection cnn, string sql, object? param = null, DbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    // ── Multi-map Query sync ──

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IEnumerable<TReturn> Query<TFirst, TSecond, TReturn>(this IDbConnection cnn, string sql, Func<TFirst, TSecond, TReturn> map, object? param = null, IDbTransaction? transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TReturn>(this IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TReturn> map, object? param = null, IDbTransaction? transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TReturn>(this IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, object? param = null, IDbTransaction? transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(this IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, object? param = null, IDbTransaction? transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IEnumerable<TReturn> Query<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(this IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, object? param = null, IDbTransaction? transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IEnumerable<TReturn> Query<TReturn>(this IDbConnection cnn, string sql, Type[] types, Func<object[], TReturn> map, object? param = null, IDbTransaction? transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    // ── Multi-map QueryAsync ──

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(this IDbConnection cnn, string sql, Func<TFirst, TSecond, TReturn> map, object? param = null, IDbTransaction? transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TReturn>(this IDbConnection cnn, CommandDefinition command, Func<TFirst, TSecond, TReturn> map, string splitOn = "Id")
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(this IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TReturn> map, object? param = null, IDbTransaction? transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TReturn>(this IDbConnection cnn, CommandDefinition command, Func<TFirst, TSecond, TThird, TReturn> map, string splitOn = "Id")
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(this IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, object? param = null, IDbTransaction? transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TReturn>(this IDbConnection cnn, CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TReturn> map, string splitOn = "Id")
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(this IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, object? param = null, IDbTransaction? transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TReturn>(this IDbConnection cnn, CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TFifth, TReturn> map, string splitOn = "Id")
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(this IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, object? param = null, IDbTransaction? transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn>(this IDbConnection cnn, CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TReturn> map, string splitOn = "Id")
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(this IDbConnection cnn, string sql, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, object? param = null, IDbTransaction? transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IEnumerable<TReturn>> QueryAsync<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn>(this IDbConnection cnn, CommandDefinition command, Func<TFirst, TSecond, TThird, TFourth, TFifth, TSixth, TSeventh, TReturn> map, string splitOn = "Id")
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IEnumerable<TReturn>> QueryAsync<TReturn>(this IDbConnection cnn, string sql, Type[] types, Func<object[], TReturn> map, object? param = null, IDbTransaction? transaction = null, bool buffered = true, string splitOn = "Id", int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    // ── Execute ──

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static int Execute(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static int Execute(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<int> ExecuteAsync(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<int> ExecuteAsync(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    // ── ExecuteScalar ──

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static object? ExecuteScalar(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static T? ExecuteScalar<T>(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static object? ExecuteScalar(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static T? ExecuteScalar<T>(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<object?> ExecuteScalarAsync(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<T?> ExecuteScalarAsync<T>(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<object?> ExecuteScalarAsync(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<T?> ExecuteScalarAsync<T>(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    // ── ExecuteReader ──

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IDataReader ExecuteReader(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IDataReader ExecuteReader(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IDataReader ExecuteReader(this IDbConnection cnn, CommandDefinition command, CommandBehavior commandBehavior)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IDataReader> ExecuteReaderAsync(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<DbDataReader> ExecuteReaderAsync(this DbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IDataReader> ExecuteReaderAsync(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<DbDataReader> ExecuteReaderAsync(this DbConnection cnn, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<IDataReader> ExecuteReaderAsync(this IDbConnection cnn, CommandDefinition command, CommandBehavior commandBehavior)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<DbDataReader> ExecuteReaderAsync(this DbConnection cnn, CommandDefinition command, CommandBehavior commandBehavior)
        => throw Nope();

    // ── QueryMultiple ──

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static GridReader QueryMultiple(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static GridReader QueryMultiple(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<GridReader> QueryMultipleAsync(this IDbConnection cnn, string sql, object? param = null, IDbTransaction? transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Task<GridReader> QueryMultipleAsync(this IDbConnection cnn, CommandDefinition command)
        => throw Nope();

    // ── GetRowParser / Parse ──

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Func<IDataReader, object> GetRowParser(this IDataReader reader, Type type, int startIndex = 0, int length = -1, bool returnNullIfFirstMissing = false)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Func<DbDataReader, object> GetRowParser(this DbDataReader reader, Type type, int startIndex = 0, int length = -1, bool returnNullIfFirstMissing = false)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Func<IDataReader, T> GetRowParser<T>(this IDataReader reader, Type? concreteType = null, int startIndex = 0, int length = -1, bool returnNullIfFirstMissing = false)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Func<DbDataReader, T> GetRowParser<T>(this DbDataReader reader, Type? concreteType = null, int startIndex = 0, int length = -1, bool returnNullIfFirstMissing = false)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IEnumerable<T> Parse<T>(this IDataReader reader)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IEnumerable<object> Parse(this IDataReader reader, Type type)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IEnumerable<dynamic> Parse(this IDataReader reader)
        => throw Nope();

    // ── Utility extension methods ──

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static List<T> AsList<T>(this IEnumerable<T>? source)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static void ReplaceLiterals(this IParameterLookup parameters, IDbCommand command)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static ICustomQueryParameter AsTableValuedParameter(this DataTable table, string? typeName = null)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static void SetTypeName(this DataTable table, string typeName)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static string? GetTypeName(this DataTable table)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static ICustomQueryParameter AsTableValuedParameter<T>(this IEnumerable<T> list, string? typeName = null) where T : IDataRecord
        => throw Nope();

    // ── Non-extension static methods ──

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static void PurgeQueryCache()
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static int GetCachedSQLCount()
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IEnumerable<Tuple<string, string, int>> GetCachedSQL(int ignoreHitCountAbove = int.MaxValue)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IEnumerable<Tuple<int, int>> GetHashCollissions()
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static void ResetTypeHandlers()
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static void AddTypeMap(Type type, DbType dbType)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static void AddTypeMap(Type type, DbType dbType, bool useGetFieldValue)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static void RemoveTypeMap(Type type)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static void AddTypeHandler(Type type, ITypeHandler handler)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static bool HasTypeHandler(Type type)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static void AddTypeHandlerImpl(Type type, ITypeHandler? handler, bool clone)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static void AddTypeHandler<T>(TypeHandler<T> handler)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static void SetDbType(IDataParameter parameter, object value)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static DbType? LookupDbType(Type type, string name, bool demand, out ITypeHandler? handler)
    { handler = null; throw Nope(); }

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static char ReadChar(object value)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static char? ReadNullableChar(object value)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static IDbDataParameter FindOrAddParameter(IDataParameterCollection parameters, IDbCommand command, string name)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static void PackListParameters(IDbCommand command, string namePrefix, object? value)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static object SanitizeParameterValue(object? value)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static string Format(object? value)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Action<IDbCommand, object> CreateParamInfoGenerator(Identity identity, bool checkForDuplicates, bool removeUnused)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static ITypeMap GetTypeMap(Type type)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static void SetTypeMap(Type type, ITypeMap? map)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Func<IDataReader, object> GetTypeDeserializer(Type type, IDataReader reader, int startBound = 0, int length = -1, bool returnNullIfFirstMissing = false)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static Func<DbDataReader, object> GetTypeDeserializer(Type type, DbDataReader reader, int startBound = 0, int length = -1, bool returnNullIfFirstMissing = false)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static void ThrowNullCustomQueryParameter(string name)
        => throw Nope();

    [RequiresDynamicCode(M)]
    [RequiresUnreferencedCode(M)]
    public static void ThrowDataException(Exception ex, int index, IDataReader reader, object? value)
        => throw Nope();
}
