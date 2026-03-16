using System.Data;
using System.Threading;

namespace Dapper;

public readonly struct CommandDefinition
{
    public string CommandText { get; }
    public object? Parameters { get; }
    public IDbTransaction? Transaction { get; }
    public int? CommandTimeout { get; }
    public CommandType? CommandType { get; }
    public CommandFlags Flags { get; }
    public CancellationToken CancellationToken { get; }

    public bool Buffered => (Flags & CommandFlags.Buffered) != 0;
    internal bool AddToCache => (Flags & CommandFlags.NoCache) == 0;
    public bool Pipelined => (Flags & CommandFlags.Pipelined) != 0;

    public CommandDefinition(
        string commandText,
        object? parameters = null,
        IDbTransaction? transaction = null,
        int? commandTimeout = null,
        CommandType? commandType = null,
        CommandFlags flags = CommandFlags.Buffered,
        CancellationToken cancellationToken = default)
    {
        CommandText = commandText;
        Parameters = parameters;
        Transaction = transaction;
        CommandTimeout = commandTimeout;
        CommandType = commandType;
        Flags = flags;
        CancellationToken = cancellationToken;
    }
}
